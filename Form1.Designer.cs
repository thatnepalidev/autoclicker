namespace autoclicker
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            btnStart = new Button();
            txtMsecs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSecs = new TextBox();
            label3 = new Label();
            txtMins = new TextBox();
            btnStop = new Button();
            grpInterval = new GroupBox();
            grpInterval.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(32, 101);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(185, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start(ALT+F)";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // txtMsecs
            // 
            txtMsecs.Location = new Point(248, 20);
            txtMsecs.Name = "txtMsecs";
            txtMsecs.Size = new Size(72, 23);
            txtMsecs.TabIndex = 3;
            txtMsecs.Text = "100";
            txtMsecs.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Msecs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 23);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Secs";
            // 
            // txtSecs
            // 
            txtSecs.Location = new Point(133, 20);
            txtSecs.Name = "txtSecs";
            txtSecs.Size = new Size(72, 23);
            txtSecs.TabIndex = 5;
            txtSecs.Text = "0";
            txtSecs.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 35);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Mins";
            // 
            // txtMins
            // 
            txtMins.Location = new Point(47, 32);
            txtMins.Name = "txtMins";
            txtMins.Size = new Size(72, 23);
            txtMins.TabIndex = 7;
            txtMins.Text = "0";
            txtMins.TextAlign = HorizontalAlignment.Right;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(226, 101);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(185, 46);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop(ALT+F)";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // grpInterval
            // 
            grpInterval.Controls.Add(label2);
            grpInterval.Controls.Add(txtSecs);
            grpInterval.Controls.Add(label1);
            grpInterval.Controls.Add(txtMsecs);
            grpInterval.Location = new Point(32, 12);
            grpInterval.Name = "grpInterval";
            grpInterval.Size = new Size(379, 60);
            grpInterval.TabIndex = 10;
            grpInterval.TabStop = false;
            grpInterval.Text = "Click Interval";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 164);
            Controls.Add(btnStop);
            Controls.Add(label3);
            Controls.Add(txtMins);
            Controls.Add(btnStart);
            Controls.Add(grpInterval);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainWindow";
            Text = "Autoclicker";
            Load += Form1_Load;
            grpInterval.ResumeLayout(false);
            grpInterval.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtMsecs;
        private Label label1;
        private Label label2;
        private TextBox txtSecs;
        private Label label3;
        private TextBox txtMins;
        private Button btnStop;
        private GroupBox grpInterval;
    }
}
