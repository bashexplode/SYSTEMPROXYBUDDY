namespace SYSTEMPROXYBUDDY
{
    partial class SYSTEMPROXYBUDDY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SYSTEMPROXYBUDDY));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.hostnameBox = new System.Windows.Forms.GroupBox();
            this.portBox = new System.Windows.Forms.GroupBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.proxyEnableBox = new System.Windows.Forms.GroupBox();
            this.PROXYON = new System.Windows.Forms.RadioButton();
            this.PROXYOFF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.hostnameBox.SuspendLayout();
            this.portBox.SuspendLayout();
            this.proxyEnableBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.proxyEnableBox);
            this.splitContainer1.Size = new System.Drawing.Size(267, 161);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.hostnameBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.portBox);
            this.splitContainer2.Size = new System.Drawing.Size(267, 45);
            this.splitContainer2.SplitterDistance = 151;
            this.splitContainer2.TabIndex = 0;
            // 
            // hostnameBox
            // 
            this.hostnameBox.Controls.Add(this.hostTextBox);
            this.hostnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostnameBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostnameBox.ForeColor = System.Drawing.Color.Snow;
            this.hostnameBox.Location = new System.Drawing.Point(0, 0);
            this.hostnameBox.Name = "hostnameBox";
            this.hostnameBox.Size = new System.Drawing.Size(151, 45);
            this.hostnameBox.TabIndex = 0;
            this.hostnameBox.TabStop = false;
            this.hostnameBox.Text = "Proxy Host";
            // 
            // portBox
            // 
            this.portBox.Controls.Add(this.portTextBox);
            this.portBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.ForeColor = System.Drawing.Color.Snow;
            this.portBox.Location = new System.Drawing.Point(0, 0);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(112, 45);
            this.portBox.TabIndex = 1;
            this.portBox.TabStop = false;
            this.portBox.Text = "Proxy Port";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostTextBox.Location = new System.Drawing.Point(3, 16);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(145, 20);
            this.hostTextBox.TabIndex = 0;
            this.hostTextBox.TextChanged += new System.EventHandler(this.hostTextBox_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portTextBox.Location = new System.Drawing.Point(3, 16);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(106, 20);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
            // 
            // proxyEnableBox
            // 
            this.proxyEnableBox.Controls.Add(this.PROXYOFF);
            this.proxyEnableBox.Controls.Add(this.PROXYON);
            this.proxyEnableBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyEnableBox.ForeColor = System.Drawing.Color.Snow;
            this.proxyEnableBox.Location = new System.Drawing.Point(0, 0);
            this.proxyEnableBox.Name = "proxyEnableBox";
            this.proxyEnableBox.Size = new System.Drawing.Size(267, 112);
            this.proxyEnableBox.TabIndex = 0;
            this.proxyEnableBox.TabStop = false;
            this.proxyEnableBox.Text = "SYSTEM PROXY";
            // 
            // PROXYON
            // 
            this.PROXYON.AutoSize = true;
            this.PROXYON.Location = new System.Drawing.Point(46, 40);
            this.PROXYON.Name = "PROXYON";
            this.PROXYON.Size = new System.Drawing.Size(41, 17);
            this.PROXYON.TabIndex = 0;
            this.PROXYON.TabStop = true;
            this.PROXYON.Text = "ON";
            this.PROXYON.UseVisualStyleBackColor = true;
            this.PROXYON.CheckedChanged += new System.EventHandler(this.PROXYON_CheckedChanged);
            // 
            // PROXYOFF
            // 
            this.PROXYOFF.AutoSize = true;
            this.PROXYOFF.Location = new System.Drawing.Point(158, 40);
            this.PROXYOFF.Name = "PROXYOFF";
            this.PROXYOFF.Size = new System.Drawing.Size(45, 17);
            this.PROXYOFF.TabIndex = 1;
            this.PROXYOFF.TabStop = true;
            this.PROXYOFF.Text = "OFF";
            this.PROXYOFF.UseVisualStyleBackColor = true;
            this.PROXYOFF.CheckedChanged += new System.EventHandler(this.PROXYOFF_CheckedChanged);
            // 
            // SYSTEMPROXYBUDDY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(267, 161);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SYSTEMPROXYBUDDY";
            this.Text = "SYSTEM PROXY BUDDY";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.hostnameBox.ResumeLayout(false);
            this.hostnameBox.PerformLayout();
            this.portBox.ResumeLayout(false);
            this.portBox.PerformLayout();
            this.proxyEnableBox.ResumeLayout(false);
            this.proxyEnableBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox hostnameBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.GroupBox portBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.GroupBox proxyEnableBox;
        private System.Windows.Forms.RadioButton PROXYOFF;
        private System.Windows.Forms.RadioButton PROXYON;
    }
}

