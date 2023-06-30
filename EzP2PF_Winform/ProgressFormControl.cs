using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzP2PF_Winform
{
    public partial class ProgressFormControl : UserControl
    {
        private class FontBinder : Component, INotifyPropertyChanged
        {
            private Font font;

            public event PropertyChangedEventHandler PropertyChanged;

            public Font Font
            {
                get { return font; }
                set
                {
                    if (font != value)
                    {
                        font = value;
                        OnPropertyChanged("Font");
                    }
                }
            }

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private FontBinder mainFont = new FontBinder();
        public override Font Font
        {
            get => mainFont.Font;
            set
            {
                mainFont.Font = value;
            }
        }

        private string sizeUnit = "KB";
        public string ObjectSizeUnit
        {
            get => sizeUnit;
            set
            {
                sizeUnit = value;
            }
        }
        private string speedUnit = "KB/s";
        public string ObjectSpeedUnit
        {
            get => speedUnit;
            set
            {
                speedUnit = value;
            }
        }

        public string ObjectName
        {
            get => NameText.Text;
            set
            {
                NameText.Text = value;
            }
        }

        public string ObjectTime
        {
            get => TimeText.Text;

            set
            {
                TimeText.Text = value;
            }
        }

        private int objectSpeed;
        public int ObjectSpeed
        {
            get => objectSpeed;

            set
            {
                objectSpeed = value;
                SpeedText.Text = objectSpeed+ speedUnit;
            }
        }

        private double progress
        {
            get
            {
                if (objectSize == 0)
                    return -1;

                return ((double)objectProgress/ (double)objectSize)*100;
            }
        }

        private uint objectSize = 0;
        public uint ObjectSize
        {
            get => objectSize;

            set
            {
                objectSize = value;
                SizeSizeText.Text = objectProgress + sizeUnit + '/' + value + sizeUnit + " (" + progress + "%)";

                ProgressVisual.Maximum = (int)value;
            }
        }

        private int objectProgress = 0;
        public int ObjectProgress
        {
            get => objectProgress;

            set
            {
                objectProgress = value;
                SizeSizeText.Text = value + sizeUnit + '/' + objectSize + sizeUnit + " (" + progress + "%)";

                ProgressVisual.Value = value;
            }
        }

        public ProgressFormControl()
        {
            InitializeComponent();

            mainFont.Font = lab1.Font;
            lab1.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            lab2.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            lab3.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            lab4.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            lab5.DataBindings.Add(new Binding("Font", mainFont, "Font"));

            NameText.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            TimeText.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            SpeedText.DataBindings.Add(new Binding("Font", mainFont, "Font"));
            SizeSizeText.DataBindings.Add(new Binding("Font", mainFont, "Font"));
        }
    }
}
