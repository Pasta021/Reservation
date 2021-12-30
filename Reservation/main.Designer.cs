namespace Reservation
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportBTN = new System.Windows.Forms.Button();
            this.adminBTN = new System.Windows.Forms.Button();
            this.ticketBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO THE GET OUT RECREATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservation.Properties.Resources.attachment_107166130;
            this.pictureBox1.Location = new System.Drawing.Point(250, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reportBTN
            // 
            this.reportBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.reportBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBTN.ForeColor = System.Drawing.Color.Purple;
            this.reportBTN.Location = new System.Drawing.Point(152, 273);
            this.reportBTN.Name = "reportBTN";
            this.reportBTN.Size = new System.Drawing.Size(114, 44);
            this.reportBTN.TabIndex = 2;
            this.reportBTN.Text = "Report";
            this.reportBTN.UseVisualStyleBackColor = false;
            this.reportBTN.Click += new System.EventHandler(this.reportBTN_Click);
            // 
            // adminBTN
            // 
            this.adminBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBTN.ForeColor = System.Drawing.Color.Purple;
            this.adminBTN.Location = new System.Drawing.Point(340, 273);
            this.adminBTN.Name = "adminBTN";
            this.adminBTN.Size = new System.Drawing.Size(114, 44);
            this.adminBTN.TabIndex = 3;
            this.adminBTN.Text = "Admin";
            this.adminBTN.UseVisualStyleBackColor = false;
            this.adminBTN.Click += new System.EventHandler(this.adminBTN_Click);
            // 
            // ticketBTN
            // 
            this.ticketBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ticketBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketBTN.ForeColor = System.Drawing.Color.Purple;
            this.ticketBTN.Location = new System.Drawing.Point(541, 273);
            this.ticketBTN.Name = "ticketBTN";
            this.ticketBTN.Size = new System.Drawing.Size(114, 44);
            this.ticketBTN.TabIndex = 4;
            this.ticketBTN.Text = "Ticket";
            this.ticketBTN.UseVisualStyleBackColor = false;
            this.ticketBTN.Click += new System.EventHandler(this.ticketBTN_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketBTN);
            this.Controls.Add(this.adminBTN);
            this.Controls.Add(this.reportBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reportBTN;
        private System.Windows.Forms.Button adminBTN;
        private System.Windows.Forms.Button ticketBTN;
    }
}