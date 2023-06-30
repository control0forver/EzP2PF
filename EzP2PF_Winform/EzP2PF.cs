using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EzP2PF_Winform.EzP2PF.DownUpInfoBase;

namespace EzP2PF_Winform
{
    public static class EzP2PF
    {
        public static class Protocol
        {
            public enum ClientMessage
            {
                PING = 0x0A,
                UPLOAD = 0x03,
                DOWNLOAD = 0x04,
                PULL_FILELIST = 0x1B
            }

            public enum ServerMessage
            {
                UNKNOWN = 0xF0,
                SERVER_ERROR = 0xF1,
                INVALID = 0xF2,
                UNDEFINED = 0xF6,
                OK = 0x01,
                TYPE_SIZE = 0x05,
                TYPE_DATA = 0x08,
                TYPE_STRING = 0x10
            }
        }

        public static Encoding StringEncoding { get; } = Encoding.Unicode;
        public static uint DownloadBufferSize { get; set; } = 4096;
        public static uint UploadBufferSize { get; set; } = 4096;

        public struct DownUpInfoBase
        {
            public string name;
            public uint size;
            public int progress;
            public int speed;
            public DateTime time;

            public enum ValueMember
            {
                name = 0,
                size,
                progress,
                speed,
                time
            }
        }
        public class DownUpInfo
        {
            private DownUpInfoBase Base;

            public string Name
            {
                get => Base.name;
                set
                {
                    Base.name = value;
                    OnValueUpdated(ValueMember.name);
                }
            }
            public uint Size
            {
                get => Base.size;
                set
                {
                    Base.size = value;
                    OnValueUpdated(ValueMember.size);
                }
            }
            public int Progress
            {
                get => Base.progress;
                set
                {
                    Base.progress = value;
                    OnValueUpdated(ValueMember.progress);
                }
            }
            public int Speed
            {
                get => Base.speed;
                set
                {
                    Base.speed = value;
                    OnValueUpdated(ValueMember.speed);
                }
            }
            public DateTime Time
            {
                get => Base.time;
                set
                {
                    Base.time = value;
                    OnValueUpdated(ValueMember.time);
                }
            }

            public DownUpInfoBase GetBase() => Base;

            public event EventHandler<ValueMember> ValueUpdated;
            protected virtual void OnValueUpdated(ValueMember UpdatedMember)
            {
                ValueUpdated?.Invoke(this, UpdatedMember);
            }
        }

        public static bool IsSocketValid(Socket socket)
        {
            try
            {
                if (socket.Poll(0, SelectMode.SelectRead))
                {
                    byte[] buffer = new byte[1];
                    if (socket.Receive(buffer, SocketFlags.Peek) == 0)
                        return false;
                }

                byte[] testBuffer = new byte[1];
                socket.Send(testBuffer, 0, SocketFlags.None);

                if (!socket.Connected)
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public class Server
        {
            private bool ShouldStop = true;
            public bool Status = false;

            public TcpListener TcpServer = new TcpListener(IPAddress.None, 0);
            public List<TcpClient> TcpClients = new List<TcpClient>();

            public Thread ThreadListen = null;
            public List<Thread> ClientThreads = new List<Thread>();

            public List<string> FilesList = new List<string>();
            public List<string> FilesFullPathList = new List<string>();

            public void ClientHandler(object client_obj)
            {
                TcpClient client = (TcpClient)client_obj;
                NetworkStream stream = client.GetStream();

                while (!ShouldStop)
                {
                    try
                    {
                        int _byte = stream.ReadByte();
                        if (_byte < 0)
                        {
                            continue;
                        }

                        byte firstByte = (byte)_byte;
                        switch ((Protocol.ClientMessage)firstByte)
                        {
                            default:
                                {
                                    stream.WriteByte((byte)Protocol.ServerMessage.UNKNOWN);
                                    break;
                                }

                            case Protocol.ClientMessage.PING:
                                {
                                    stream.WriteByte((byte)Protocol.ServerMessage.OK);
                                    break;
                                }

                            case Protocol.ClientMessage.PULL_FILELIST:
                                {
                                    stream.WriteByte((byte)Protocol.ServerMessage.OK);

                                    List<byte> dataBytes = new List<byte>();
                                    foreach (string file in FilesList)
                                    {
                                        dataBytes.AddRange(StringEncoding.GetBytes(file));
                                        dataBytes.Add(0x00);
                                        dataBytes.Add(0x00); // dual '\0' symbol bcs. of stupid c# char needs 2 bytes
                                    }

                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_SIZE);
                                    stream.Write(BitConverter.GetBytes((UInt32)dataBytes.Count), 0, sizeof(UInt32));

                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_DATA);
                                    stream.Write(dataBytes.ToArray(), 0, dataBytes.Count);

                                    break;
                                }

                            case Protocol.ClientMessage.DOWNLOAD:
                                {
                                    stream.WriteByte((byte)Protocol.ServerMessage.OK);

                                    byte[] indexBytes = new byte[sizeof(UInt32)];
                                    stream.Read(indexBytes, 0, sizeof(UInt32));
                                    UInt32 fileIndex = BitConverter.ToUInt32(indexBytes, 0);

                                    if (fileIndex > FilesFullPathList.Count)
                                    {
                                        stream.WriteByte((byte)Protocol.ServerMessage.INVALID);
                                        break;
                                    }

                                    stream.WriteByte((byte)Protocol.ServerMessage.OK);
                                    // File Exists

                                    // Send File Name Size
                                    string fileName = FilesList[(int)fileIndex];
                                    byte[] fileNameBytes = StringEncoding.GetBytes(fileName);
                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_SIZE);
                                    byte[] fileNameSizeBytes = BitConverter.GetBytes((UInt32)fileNameBytes.Length);
                                    stream.Write(fileNameSizeBytes, 0, sizeof(UInt32));

                                    // Send File Name
                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_STRING);
                                    stream.Write(fileNameBytes, 0, fileNameBytes.Length);


                                    // Send File Size
                                    string filePath = FilesFullPathList[(int)fileIndex];
                                    FileInfo file = new FileInfo(filePath);
                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_SIZE);
                                    byte[] fileSizeBytes = BitConverter.GetBytes((UInt32)file.Length);
                                    stream.Write(fileSizeBytes, 0, sizeof(UInt32));

                                    // Send File
                                    stream.WriteByte((byte)Protocol.ServerMessage.TYPE_DATA);
                                    FileStream fileStream = file.OpenRead();
                                    byte[] fileDataBuffer = new byte[DownloadBufferSize];
                                    int bytesRead;
                                    while ((bytesRead = fileStream.Read(fileDataBuffer, 0, fileDataBuffer.Length)) > 0)
                                    {
                                        stream.Write(fileDataBuffer, 0, bytesRead);
                                    }
                                    fileStream.Close();

                                    break;
                                }

                            case Protocol.ClientMessage.UPLOAD:
                                {
                                    stream.WriteByte((byte)Protocol.ServerMessage.UNDEFINED);
                                    break;
                                }
                        }
                    }
                    catch (Exception)
                    {
                        {
                            if (!IsSocketValid(client.Client))
                            {
                                // Force release and exit
                                try
                                {
                                    TcpClients.Remove(client);
                                    client.Close();

                                    return;
                                }
                                catch (Exception)
                                {
                                    return;
                                }
                            }

                            try
                            {
                                stream.WriteByte((byte)Protocol.ServerMessage.SERVER_ERROR);
                            }
                            catch (Exception) { continue; }
                            continue;
                        }
                    }
                }
            }

            public void ListenThread()
            {
                while (!ShouldStop)
                {
                    try
                    {
                        TcpClient client = TcpServer.AcceptTcpClient();
                        Thread clientThread = new Thread(ClientHandler);
                        clientThread.Start(client);
                        TcpClients.Add(client);
                        ClientThreads.Add(clientThread);
                    }
                    catch (Exception) { continue; }
                }
            }

            public bool Start(IPAddress ipaddr, int port, bool IPv6Only)
            {
                ShouldStop = false;

                try
                {
                    TcpServer = new TcpListener(ipaddr, port);
                    if (!IPv6Only)
                    {
                        TcpServer.Server.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
                    }
                    TcpServer.Start();

                    ThreadListen = new Thread(ListenThread);
                    ThreadListen.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Status = true;
                return true;
            }

            public bool Stop()
            {
                ShouldStop = true;

                try
                {
                    TcpServer.Stop();
                    ThreadListen.Join();

                    foreach (Thread clientThread in ClientThreads.ToArray())
                    {
                        clientThread.Abort();
                        clientThread.Join();
                        ClientThreads.Remove(clientThread);
                    }
                    foreach (TcpClient tcpClient in TcpClients.ToArray())
                    {
                        tcpClient.Close();
                        TcpClients.Remove(tcpClient);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Status = false;
                return true;
            }
        }

        public class Client
        {
            public bool Connected = false;

            public TcpClient TcpClient = new TcpClient();

            public List<string> Files = new List<string>();


            public bool Connect(IPAddress address, int port, bool isV6 = false)
            {
                try
                {
                    TcpClient = isV6 ? new TcpClient(AddressFamily.InterNetworkV6):new TcpClient();
                    TcpClient.Connect(address, port);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Connected = true;
                return true;
            }

            public bool Disconnect()
            {
                try
                {
                    TcpClient.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Connected = false;
                return true;
            }

            public Mutex TcpMutex = new Mutex();

            public string[] PullFilesList(out bool Defferent)
            {
                Defferent = true;

                if (!Connected)
                    return null;

                TcpMutex.WaitOne();
                string[] files =null;

                try
                {
                    NetworkStream stream = TcpClient.GetStream();
                    stream.ReadTimeout = 4500;

                    stream.WriteByte((byte)Protocol.ClientMessage.PULL_FILELIST);

                    byte msg = (byte)stream.ReadByte();
                    if (msg != (byte)Protocol.ServerMessage.OK)
                    {
                        goto failed;
                    }

                    msg = (byte)stream.ReadByte();
                    if (msg != (byte)Protocol.ServerMessage.TYPE_SIZE)
                        goto failed;

                    byte[] sizeBytes = new byte[sizeof(UInt32)];
                    stream.Read(sizeBytes, 0, sizeof(UInt32));
                    UInt32 size = BitConverter.ToUInt32(sizeBytes,0);
                    byte[] data = new byte[size];

                    msg = (byte)stream.ReadByte();
                    if (msg != (byte)Protocol.ServerMessage.TYPE_DATA)
                        goto failed;

                    stream.ReadTimeout = Timeout.Infinite;
                    stream.Read(data, 0, (int)size);

                    string strings = StringEncoding.GetString(data);
                    files = strings.Split((char)0x0000); // dual '\0' symbol bcs. of stupid c# char needs 2 bytes
                }
                catch (Exception) { goto failed; }

                if (files.SequenceEqual(Files.ToArray()))
                    Defferent = false;

                Files.Clear();
                Files.AddRange(files);

                TcpMutex.ReleaseMutex();
                return files;

            failed:
                TcpMutex.ReleaseMutex();
                return null;
            }

            public void Upload()
            {

            }

            public bool Download(UInt32 FileIndex, string SaveDir, ref DownUpInfo info)
            {
                if (!Connected)
                    return false;

                TcpMutex.WaitOne();
                try
                {
                    NetworkStream stream = TcpClient.GetStream();

                    stream.WriteByte((byte)Protocol.ClientMessage.DOWNLOAD);
                    byte msg = (byte)stream.ReadByte();

                    if (msg != (byte)Protocol.ServerMessage.OK)
                    {
                        goto failed;
                    }

                    info.Time = DateTime.Now;

                    byte[] indexBytes = BitConverter.GetBytes(FileIndex);
                    stream.Write(indexBytes, 0, sizeof(UInt32)); // Send Index

                    if (stream.ReadByte() != (byte)Protocol.ServerMessage.OK) // may be INVALID msg due to file not exists any more on server
                        goto failed;

                    // Get File Name
                    if (stream.ReadByte() != (byte)Protocol.ServerMessage.TYPE_SIZE)
                        goto failed;
                    byte[] nameSizeBytes = new byte[sizeof(UInt32)];
                    stream.Read(nameSizeBytes, 0, sizeof(UInt32));
                    UInt32 fileNameSize = BitConverter.ToUInt32(nameSizeBytes, 0);
                    if (stream.ReadByte() != (byte)Protocol.ServerMessage.TYPE_STRING)
                        goto failed;
                    byte[] nameBytes = new byte[fileNameSize];
                    stream.Read(nameBytes, 0, (int)fileNameSize);
                    string fileName = StringEncoding.GetString(nameBytes);

                    info.Name = fileName;

                    // Get File Size
                    if (stream.ReadByte() != (byte)Protocol.ServerMessage.TYPE_SIZE)
                        goto failed;
                    byte[] sizeBytes = new byte[sizeof(UInt32)];
                    stream.Read(sizeBytes, 0, sizeof(UInt32));
                    UInt32 fileSize = BitConverter.ToUInt32(sizeBytes, 0);

                    info.Size = fileSize;

                    // Process Path
                    char[] SaveDirCharArray = SaveDir.ToCharArray();
                    if (SaveDirCharArray[SaveDir.Length - 1] != '/' || SaveDirCharArray[SaveDir.Length - 1] != '\\')
                    {
                        SaveDir += '/';
                    }
                    string Path = SaveDir + fileName;

                    // Make File Data
                    if (stream.ReadByte() != (byte)Protocol.ServerMessage.TYPE_DATA)
                        goto failed;

                    FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.Read);
                    List<byte> fileDatas = new List<byte>();
                    List<Task> WritingTasks = new List<Task>();
                    Stopwatch SpeedCounter = new Stopwatch();
                    SpeedCounter.Start();
                    int readBytesCounterForSpeedCal = 0;
                    for (int readBytesCount = 0; readBytesCount < fileSize;)
                    {
                        byte[] fileDataBuffer = new byte[DownloadBufferSize];
                        int bytesRead = stream.Read(fileDataBuffer, 0, (int)DownloadBufferSize);

                        fileDatas.AddRange(fileDataBuffer);

                        readBytesCounterForSpeedCal += bytesRead;
                        if (SpeedCounter.ElapsedMilliseconds >= 1000)
                        {
                            double speedKBPerSec = (double)readBytesCounterForSpeedCal / 1024 / (SpeedCounter.ElapsedMilliseconds / 1000);

                            info.Speed = (int)speedKBPerSec;

                            SpeedCounter.Restart();
                            readBytesCounterForSpeedCal = 0;
                        }

                        WritingTasks.Add(fileStream.WriteAsync(fileDatas.ToArray(), readBytesCount, bytesRead));
                        readBytesCount += bytesRead;
                        info.Progress = readBytesCount;
                    }
                    foreach (Task task in WritingTasks)
                    {
                        task.Wait();
                    }
                    fileStream.Flush();
                    fileStream.Close();
                }
                catch (Exception)
                {
                    throw;
                }

                TcpMutex.ReleaseMutex();
                return true;

            failed:
                TcpMutex.ReleaseMutex();
                return false;
            }

            public bool Download(UInt32 FileIndex, string SaveDir)
            {
                DownUpInfo _= new DownUpInfo();
                return Download(FileIndex, SaveDir, ref _);
            }
            
            public int Ping()
            {
                if (!Connected)
                    return -1;

                TcpMutex.WaitOne();
                Stopwatch stopwatch = new Stopwatch();
                try
                {
                    NetworkStream stream = TcpClient.GetStream();
                    // stream.ReadTimeout = 2000;

                    stopwatch.Start();
                    stream.WriteByte((byte)Protocol.ClientMessage.PING);
                    byte msg = (byte)stream.ReadByte();
                    stopwatch.Stop();

                    if (msg != (byte)Protocol.ServerMessage.OK)
                    {
                        goto failed;
                    }
                }
                catch (Exception)
                {
                    goto failed;
                }

                TcpMutex.ReleaseMutex();
                return (int)stopwatch.ElapsedMilliseconds;

            failed:
                TcpMutex.ReleaseMutex();
                return - 1;
            }
        }
    }
}
