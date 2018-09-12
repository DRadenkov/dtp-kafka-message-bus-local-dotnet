namespace UEFAMessagebusTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.UEFALogo = new System.Windows.Forms.PictureBox();
            this.groupBoxProducer = new System.Windows.Forms.GroupBox();
            this.sentNum = new System.Windows.Forms.Label();
            this.sentLbl = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.PictureBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UEFALogo)).BeginInit();
            this.groupBoxProducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(112, 28);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(356, 33);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "UEFA Messagebus Tester";
            // 
            // UEFALogo
            // 
            this.UEFALogo.Image = ((System.Drawing.Image)(resources.GetObject("UEFALogo.Image")));
            this.UEFALogo.Location = new System.Drawing.Point(14, 9);
            this.UEFALogo.Name = "UEFALogo";
            this.UEFALogo.Size = new System.Drawing.Size(81, 80);
            this.UEFALogo.TabIndex = 1;
            this.UEFALogo.TabStop = false;
            // 
            // groupBoxProducer
            // 
            this.groupBoxProducer.Controls.Add(this.sentNum);
            this.groupBoxProducer.Controls.Add(this.sentLbl);
            this.groupBoxProducer.Controls.Add(this.connectStatus);
            this.groupBoxProducer.Controls.Add(this.sendButton);
            this.groupBoxProducer.Controls.Add(this.connectBtn);
            this.groupBoxProducer.Location = new System.Drawing.Point(14, 111);
            this.groupBoxProducer.Name = "groupBoxProducer";
            this.groupBoxProducer.Size = new System.Drawing.Size(416, 327);
            this.groupBoxProducer.TabIndex = 2;
            this.groupBoxProducer.TabStop = false;
            this.groupBoxProducer.Text = "Avro Producer";
            // 
            // sentNum
            // 
            this.sentNum.AutoSize = true;
            this.sentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentNum.Location = new System.Drawing.Point(83, 160);
            this.sentNum.Name = "sentNum";
            this.sentNum.Size = new System.Drawing.Size(0, 20);
            this.sentNum.TabIndex = 4;
            // 
            // sentLbl
            // 
            this.sentLbl.AutoSize = true;
            this.sentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentLbl.Location = new System.Drawing.Point(20, 160);
            this.sentLbl.Name = "sentLbl";
            this.sentLbl.Size = new System.Drawing.Size(57, 20);
            this.sentLbl.TabIndex = 3;
            this.sentLbl.Text = "Sent :";
            // 
            // connectStatus
            // 
            this.connectStatus.BackColor = System.Drawing.Color.Gray;
            this.connectStatus.Location = new System.Drawing.Point(163, 42);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(21, 16);
            this.connectStatus.TabIndex = 2;
            this.connectStatus.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Lime;
            this.sendButton.Location = new System.Drawing.Point(20, 98);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(118, 35);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connectBtn.Location = new System.Drawing.Point(20, 33);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(118, 35);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBoxProducer);
            this.Controls.Add(this.UEFALogo);
            this.Controls.Add(this.HeaderLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "UEFA Messagebus .NET Tester";
            ((System.ComponentModel.ISupportInitialize)(this.UEFALogo)).EndInit();
            this.groupBoxProducer.ResumeLayout(false);
            this.groupBoxProducer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.PictureBox UEFALogo;
        private System.Windows.Forms.GroupBox groupBoxProducer;
        private System.Windows.Forms.Label sentNum;
        private System.Windows.Forms.Label sentLbl;
        private System.Windows.Forms.PictureBox connectStatus;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectBtn;
    }
}

