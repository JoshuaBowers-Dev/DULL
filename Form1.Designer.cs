
namespace DULL
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btn_startstop = new System.Windows.Forms.Button();
            this.tb_ipaddress = new System.Windows.Forms.TextBox();
            this.rb_anyip = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_specificip = new System.Windows.Forms.RadioButton();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.btn_toggleLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startstop
            // 
            this.btn_startstop.Location = new System.Drawing.Point(13, 13);
            this.btn_startstop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startstop.Name = "btn_startstop";
            this.btn_startstop.Size = new System.Drawing.Size(100, 53);
            this.btn_startstop.TabIndex = 0;
            this.btn_startstop.Text = "Start";
            this.btn_startstop.UseVisualStyleBackColor = true;
            this.btn_startstop.Click += new System.EventHandler(this.btn_startstop_Click);
            // 
            // tb_ipaddress
            // 
            this.tb_ipaddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ipaddress.Enabled = false;
            this.tb_ipaddress.Location = new System.Drawing.Point(206, 16);
            this.tb_ipaddress.Name = "tb_ipaddress";
            this.tb_ipaddress.Size = new System.Drawing.Size(212, 23);
            this.tb_ipaddress.TabIndex = 1;
            // 
            // rb_anyip
            // 
            this.rb_anyip.AutoSize = true;
            this.rb_anyip.Checked = true;
            this.rb_anyip.Location = new System.Drawing.Point(123, 45);
            this.rb_anyip.Name = "rb_anyip";
            this.rb_anyip.Size = new System.Drawing.Size(66, 21);
            this.rb_anyip.TabIndex = 2;
            this.rb_anyip.TabStop = true;
            this.rb_anyip.Text = "Any IP";
            this.rb_anyip.UseVisualStyleBackColor = true;
            this.rb_anyip.CheckedChanged += new System.EventHandler(this.rb_anyip_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address:";
            // 
            // rb_specificip
            // 
            this.rb_specificip.AutoSize = true;
            this.rb_specificip.Location = new System.Drawing.Point(195, 45);
            this.rb_specificip.Name = "rb_specificip";
            this.rb_specificip.Size = new System.Drawing.Size(91, 21);
            this.rb_specificip.TabIndex = 4;
            this.rb_specificip.Text = "Specific IP";
            this.rb_specificip.UseVisualStyleBackColor = true;
            // 
            // nud_port
            // 
            this.nud_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_port.Location = new System.Drawing.Point(348, 45);
            this.nud_port.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(70, 23);
            this.nud_port.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // lbl_debug
            // 
            this.lbl_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_debug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_debug.Location = new System.Drawing.Point(13, 131);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_debug.Size = new System.Drawing.Size(405, 95);
            this.lbl_debug.TabIndex = 7;
            this.lbl_debug.Text = "Application started.";
            // 
            // btn_toggleLog
            // 
            this.btn_toggleLog.Location = new System.Drawing.Point(13, 74);
            this.btn_toggleLog.Margin = new System.Windows.Forms.Padding(4);
            this.btn_toggleLog.Name = "btn_toggleLog";
            this.btn_toggleLog.Size = new System.Drawing.Size(100, 53);
            this.btn_toggleLog.TabIndex = 8;
            this.btn_toggleLog.Text = "Start Log";
            this.btn_toggleLog.UseVisualStyleBackColor = true;
            this.btn_toggleLog.Click += new System.EventHandler(this.btn_toggleLog_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 234);
            this.Controls.Add(this.btn_toggleLog);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.rb_specificip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_anyip);
            this.Controls.Add(this.tb_ipaddress);
            this.Controls.Add(this.btn_startstop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "DULL";
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startstop;
        private System.Windows.Forms.TextBox tb_ipaddress;
        private System.Windows.Forms.RadioButton rb_anyip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_specificip;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_debug;
        private System.Windows.Forms.Button btn_toggleLog;
    }
}

