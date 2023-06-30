using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static EzP2PF_Winform.EzP2PF;
using static EzP2PF_Winform.EzP2PF.DownUpInfoBase;

namespace EzP2PF_Winform
{
    public partial class MainForm : Form
    {
        EzP2PF.Server server = null;
        EzP2PF.Client client = null;

        List<TcpClient> localServerTcpClientsList = new List<TcpClient>();

        Thread ThreadServerFilesListUpdater = null;
        Thread ThreadServerClientsListUpdater = null;
        Thread ThreadClientServerFilesListPuller = null;
        Thread ThreadClientServerPing = null;

        public static bool TryParseIPAddressAndPort(string ipAddressAndPort, out IPAddress ipAddress, out int port, out bool isV6)
        {
            ipAddress = null;
            port = 0;
            isV6 = false;

            if (ipAddressAndPort.IndexOf('[') != -1 && ipAddressAndPort.IndexOf(']') != -1)
                isV6 = true;


            string[] parts = { ipAddressAndPort.Substring(0, ipAddressAndPort.LastIndexOf(':')), ipAddressAndPort.Substring(ipAddressAndPort.LastIndexOf(':') + 1) };

            if (parts.Length != 2)
            {
                return false;
            }

            string ipAddressString = parts[0];
            string portString = parts[1];

            if (!int.TryParse(portString, out port))
            {
                return false;
            }
            else if (port < IPEndPoint.MinPort || port > IPEndPoint.MaxPort)
                return false;

            if (IPAddress.TryParse(ipAddressString, out ipAddress))
            {
                return true;
            }

            return false;
        }

        public void LockServerOptions(bool Lock)
        {
            txtbox_ServerPort.Enabled = !Lock;
            chkbox_ServerEnableIPv6.Enabled = !Lock;
        }

        public void LockClientOptions(bool Lock)
        {
            txtbox_ClientServer.Enabled = !Lock;
        }

        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();

            server = new EzP2PF.Server();
            client = new EzP2PF.Client();

            ThreadServerFilesListUpdater = new Thread(ServerFilesListUpdater);
            ThreadServerClientsListUpdater = new Thread(ServerClientsListUpdater);
            ThreadClientServerFilesListPuller = new Thread(ClientFilesListPuller);
            ThreadClientServerPing = new Thread(ClientServerPing);

            ThreadServerFilesListUpdater.Start();
            ThreadServerClientsListUpdater.Start();
            ThreadClientServerFilesListPuller.Start();
            ThreadClientServerPing.Start();

            lstbox_ServerFilesList.DataSource = server.FilesList;

        }

        private void txtbox_ClientSavePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void txtbox_ClientSavePath_DragDrop(object sender, DragEventArgs e)
        {
            txtbox_ClientSavePath.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void lstbox_ClientServerFilesList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void lstbox_ClientServerFilesList_DragDrop(object sender, DragEventArgs e)
        {
            tabcontrol_UpDownLoad.SelectedIndex = 0;
            ClientPage_Upload.Focus();
            txtbox_UploadFilePath.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            btn_Upload_Click(sender, EventArgs.Empty);
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {

        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            int index = lstbox_ClientServerFilesList.SelectedIndex;
            if (index == -1)
                return;

            downloadProgressInfo.ObjectSizeUnit = "KB";
            downloadProgressInfo.ObjectSpeedUnit = "KB/s";

            EzP2PF.DownUpInfo downUpInfo = new EzP2PF.DownUpInfo();
            downUpInfo.ValueUpdated += (object sdr, ValueMember updatedValue) =>
            {
                DownUpInfoBase info = ((DownUpInfo)sdr).GetBase();
                switch (updatedValue)
                {
                    default:
                        break;

                    case ValueMember.name:
                        downloadProgressInfo.ObjectName = info.name;
                        break;
                    case ValueMember.size:
                        downloadProgressInfo.ObjectSize = info.size;
                        break;
                    case ValueMember.progress:
                        downloadProgressInfo.ObjectProgress = info.progress;
                        break;
                    case ValueMember.speed:
                        downloadProgressInfo.ObjectSpeed = info.speed;
                        break;
                    case ValueMember.time:
                        downloadProgressInfo.ObjectTime = info.time.ToString();
                        break;
                }
            };
            MessageBox.Show(client.Download((uint)index, txtbox_ClientSavePath.Text, ref downUpInfo) ?
                "Download Successfully." : "Failed to Download File.");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                IPAddress ipaddr = null;
                int port = 0;
                bool v6 = false;

                if (!TryParseIPAddressAndPort(txtbox_ClientServer.Text, out ipaddr, out port, out v6))
                {
                    MessageBox.Show("Invalid IPAddress & Port");
                    return;
                }

                if (!client.Connect(ipaddr, port, v6))
                    return;

                LockClientOptions(true);
                lab_ClientServerConnectStatus.Text = "Server Connection: Connected";
                btn_Connect.Text = "Disconnect";
            }
            else
            {
                if (!client.Disconnect())
                    return;

                LockClientOptions(false);
                lab_ClientServerConnectStatus.Text = "Server Connection: Disconnected";
                btn_Connect.Text = "Connect";
            }
        }

        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            if (server.Status)
            {
                if (!server.Stop())
                    return;

                LockServerOptions(false);
                lab_ServerStatus.Text = "ServerStatus: Stopped";
                btn_StartServer.Text = "Start";
            }
            else
            {
                if (chkbox_ServerEnableIPv6.Checked)
                {
                    if (!server.Start(IPAddress.IPv6Any, int.Parse(txtbox_ServerPort.Text), false))
                        return;
                }
                else
                {
                    if (!server.Start(IPAddress.Any, int.Parse(txtbox_ServerPort.Text), true))
                        return;
                }

                LockServerOptions(true);
                lab_ServerStatus.Text = "ServerStatus: Running";
                btn_StartServer.Text = "Stop";
            }
        }


        private void ClientServerPing()
        {
            while (true)
            {
                Thread.Sleep(1000);

                int pingMS = client.Ping();
                lab_ClientServerPing.Text = "Ping: " + pingMS + "ms";
            }
        }

        private void ServerClientsListUpdater()
        {
            int delay = 1500;
            for (; ; )
            {
                Thread.Sleep(delay);

                if (!localServerTcpClientsList.SequenceEqual(server.TcpClients))
                {
                    localServerTcpClientsList.Clear();
                    localServerTcpClientsList.AddRange(server.TcpClients);

                    int selectedIndex = lstbox_ServerClientsList.SelectedIndex;

                    lstbox_ServerClientsList.Items.Clear();
                    foreach (var client in localServerTcpClientsList)
                        lstbox_ServerClientsList.Items.Add(client.Client.RemoteEndPoint.ToString());

                    if (selectedIndex <= localServerTcpClientsList.Count)
                        lstbox_ServerClientsList.SelectedIndex = selectedIndex;
                }
            }
        }

        private void ServerFilesListUpdater()
        {
            int delay = 1500;
            for (; ; )
            {
                if (!int.TryParse(txtbox_ServerFilesListUpdateInterval.Text, out delay))
                    delay = 1500;
                Thread.Sleep(delay);

                string[] files = null;
                try
                {
                    files = Directory.GetFiles(txtbox_FilesRootPath.Text);
                }
                catch (Exception)
                { continue; }

                if (!files.SequenceEqual(server.FilesFullPathList.ToArray()))
                {
                    server.FilesFullPathList.Clear();
                    server.FilesFullPathList.AddRange(files);

                    for (int i = 0; i < files.Length; ++i)
                    {
                        files[i] = Path.GetFileName(files[i]);
                    }

                    int selectedIndex = lstbox_ServerFilesList.SelectedIndex;

                    server.FilesList.Clear();
                    server.FilesList.AddRange(files);

                    lstbox_ServerFilesList.DataSource = new BindingList<string>(server.FilesList);

                    if (selectedIndex <= files.Length)
                        lstbox_ServerFilesList.SelectedIndex = selectedIndex;
                }
            }
        }

        private void ClientFilesListPuller()
        {
            while (true)
            {
                Thread.Sleep(1500);

                bool Defferent;
                string[] files = client.PullFilesList(out Defferent);
                if (files == null)
                    continue;

                if (Defferent)
                {
                    int selectedIndex = lstbox_ClientServerFilesList.SelectedIndex;

                    lstbox_ClientServerFilesList.Items.Clear();
                    lstbox_ClientServerFilesList.Items.AddRange(files);

                    lstbox_ClientServerFilesList.SelectedIndex = selectedIndex;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_PingServer_Click(object sender, EventArgs e)
        {
            ClientServerPing();
        }

        private void btn_UpdateFIlesList_Click(object sender, EventArgs e)
        {
            ClientFilesListPuller();
        }

        private void lstbox_ClientServerFilesList_DoubleClick(object sender, EventArgs e)
        {
            int index = lstbox_ClientServerFilesList.SelectedIndex;
            if (index < 0)
                return;

            btn_Download_Click(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
