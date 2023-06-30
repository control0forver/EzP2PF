namespace EzP2PF_Winform
{
    partial class ProgressFormControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Formatter = new System.Windows.Forms.TableLayoutPanel();
            this.SpeedText = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.ProgressVisual = new System.Windows.Forms.ProgressBar();
            this.SizeSizeText = new System.Windows.Forms.Label();
            this.Formatter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Formatter
            // 
            this.Formatter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Formatter.ColumnCount = 2;
            this.Formatter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.Formatter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.Formatter.Controls.Add(this.SpeedText, 1, 2);
            this.Formatter.Controls.Add(this.TimeText, 1, 1);
            this.Formatter.Controls.Add(this.NameText, 1, 0);
            this.Formatter.Controls.Add(this.lab1, 0, 0);
            this.Formatter.Controls.Add(this.lab2, 0, 1);
            this.Formatter.Controls.Add(this.lab3, 0, 2);
            this.Formatter.Controls.Add(this.lab4, 0, 3);
            this.Formatter.Controls.Add(this.lab5, 0, 4);
            this.Formatter.Controls.Add(this.ProgressVisual, 1, 4);
            this.Formatter.Controls.Add(this.SizeSizeText, 1, 3);
            this.Formatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formatter.Location = new System.Drawing.Point(0, 0);
            this.Formatter.Margin = new System.Windows.Forms.Padding(0);
            this.Formatter.Name = "Formatter";
            this.Formatter.RowCount = 5;
            this.Formatter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00049F));
            this.Formatter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.Formatter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.Formatter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.Formatter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Formatter.Size = new System.Drawing.Size(547, 159);
            this.Formatter.TabIndex = 0;
            // 
            // SpeedText
            // 
            this.SpeedText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeedText.AutoSize = true;
            this.SpeedText.Font = new System.Drawing.Font("Arial", 10.5F);
            this.SpeedText.Location = new System.Drawing.Point(378, 70);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(15, 16);
            this.SpeedText.TabIndex = 9;
            this.SpeedText.Text = "0";
            // 
            // TimeText
            // 
            this.TimeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeText.AutoSize = true;
            this.TimeText.Font = new System.Drawing.Font("Arial", 10.5F);
            this.TimeText.Location = new System.Drawing.Point(378, 39);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(15, 16);
            this.TimeText.TabIndex = 8;
            this.TimeText.Text = "0";
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Arial", 10.5F);
            this.NameText.Location = new System.Drawing.Point(365, 8);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(42, 16);
            this.NameText.TabIndex = 7;
            this.NameText.Text = "name";
            // 
            // lab1
            // 
            this.lab1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Arial", 15F);
            this.lab1.Location = new System.Drawing.Point(82, 4);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(61, 23);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Name";
            // 
            // lab2
            // 
            this.lab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Arial", 15F);
            this.lab2.Location = new System.Drawing.Point(87, 35);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(52, 23);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "Time";
            // 
            // lab3
            // 
            this.lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Arial", 15F);
            this.lab3.Location = new System.Drawing.Point(79, 66);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(67, 23);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "Speed";
            // 
            // lab4
            // 
            this.lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Arial", 15F);
            this.lab4.Location = new System.Drawing.Point(62, 97);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(102, 23);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "Size / Size";
            // 
            // lab5
            // 
            this.lab5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Arial", 15F);
            this.lab5.Location = new System.Drawing.Point(68, 130);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(90, 23);
            this.lab5.TabIndex = 4;
            this.lab5.Text = "Progress";
            // 
            // ProgressVisual
            // 
            this.ProgressVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressVisual.Location = new System.Drawing.Point(226, 125);
            this.ProgressVisual.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressVisual.Name = "ProgressVisual";
            this.ProgressVisual.Size = new System.Drawing.Size(320, 33);
            this.ProgressVisual.TabIndex = 5;
            // 
            // SizeSizeText
            // 
            this.SizeSizeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SizeSizeText.AutoSize = true;
            this.SizeSizeText.Font = new System.Drawing.Font("Arial", 10.5F);
            this.SizeSizeText.Location = new System.Drawing.Point(355, 101);
            this.SizeSizeText.Name = "SizeSizeText";
            this.SizeSizeText.Size = new System.Drawing.Size(61, 16);
            this.SizeSizeText.TabIndex = 6;
            this.SizeSizeText.Text = "0/0 (0%)";
            // 
            // ProgressFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Formatter);
            this.Name = "ProgressFormControl";
            this.Size = new System.Drawing.Size(547, 159);
            this.Formatter.ResumeLayout(false);
            this.Formatter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Formatter;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.ProgressBar ProgressVisual;
        private System.Windows.Forms.Label SizeSizeText;
        private System.Windows.Forms.Label SpeedText;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Label NameText;
    }
}
