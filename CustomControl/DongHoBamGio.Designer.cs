namespace CustomControl
{
    partial class DongHoBamGio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTime = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.btnStart = new CustomControl.HoverButton();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(30, 14);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(150, 25);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00 000";
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(108, 52);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(86, 36);
            this.btnLap.TabIndex = 2;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // DongHoBamGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Name = "DongHoBamGio";
            this.Size = new System.Drawing.Size(220, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private HoverButton btnStart;
        private System.Windows.Forms.Button btnLap;
    }
}
