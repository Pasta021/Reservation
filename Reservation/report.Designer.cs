namespace Reservation
{
    partial class report
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyreportBTN = new System.Windows.Forms.Button();
            this.weeklyreportBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBTN.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.ForeColor = System.Drawing.Color.Purple;
            this.exitBTN.Location = new System.Drawing.Point(696, 392);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 29);
            this.exitBTN.TabIndex = 0;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT";
            // 
            // dailyreportBTN
            // 
            this.dailyreportBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dailyreportBTN.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyreportBTN.ForeColor = System.Drawing.Color.Purple;
            this.dailyreportBTN.Location = new System.Drawing.Point(233, 61);
            this.dailyreportBTN.Name = "dailyreportBTN";
            this.dailyreportBTN.Size = new System.Drawing.Size(323, 74);
            this.dailyreportBTN.TabIndex = 2;
            this.dailyreportBTN.Text = "View Daily Report";
            this.dailyreportBTN.UseVisualStyleBackColor = false;
            // 
            // weeklyreportBTN
            // 
            this.weeklyreportBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.weeklyreportBTN.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyreportBTN.ForeColor = System.Drawing.Color.Purple;
            this.weeklyreportBTN.Location = new System.Drawing.Point(233, 248);
            this.weeklyreportBTN.Name = "weeklyreportBTN";
            this.weeklyreportBTN.Size = new System.Drawing.Size(323, 74);
            this.weeklyreportBTN.TabIndex = 3;
            this.weeklyreportBTN.Text = "View Weekly Report";
            this.weeklyreportBTN.UseVisualStyleBackColor = false;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weeklyreportBTN);
            this.Controls.Add(this.dailyreportBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "report";
            this.Text = "report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dailyreportBTN;
        private System.Windows.Forms.Button weeklyreportBTN;
    }
}