using System;

namespace AlertRelax
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeDisp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.timeRelax = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timeDisp
            // 
            this.timeDisp.Enabled = false;
            this.timeDisp.Location = new System.Drawing.Point(61, 60);
            this.timeDisp.Name = "timeDisp";
            this.timeDisp.ReadOnly = true;
            this.timeDisp.Size = new System.Drawing.Size(164, 20);
            this.timeDisp.TabIndex = 0;
            this.timeDisp.Text = "0:0:0";
            this.timeDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // timeRelax
            // 
            this.timeRelax.Interval = 1000;
            this.timeRelax.Tick += new System.EventHandler(this.timeRelax_Tick);
            // 
            // sysTray
            // 
            this.sysTray.BalloonTipText = "Đại ca học vui vẻ :v";
            this.sysTray.BalloonTipTitle = "Đệ Tử";
            this.sysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTray.Icon")));
            this.sysTray.Text = "Relax Alert";
            this.sysTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sysTray_MouseClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeDisp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relax Alert";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox timeDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Timer timeRelax;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon sysTray;
    }
}

