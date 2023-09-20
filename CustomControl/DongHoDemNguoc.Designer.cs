namespace CustomControl
{
    partial class DongHoDemNguoc
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSecond
            // 
            this.tbSecond.BackColor = System.Drawing.SystemColors.Menu;
            this.tbSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecond.Location = new System.Drawing.Point(110, 3);
            this.tbSecond.MaxLength = 2;
            this.tbSecond.Multiline = true;
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(48, 26);
            this.tbSecond.TabIndex = 17;
            this.tbSecond.Text = "00";
            this.tbSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // tbMinute
            // 
            this.tbMinute.BackColor = System.Drawing.SystemColors.Menu;
            this.tbMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinute.Location = new System.Drawing.Point(56, 3);
            this.tbMinute.MaxLength = 2;
            this.tbMinute.Multiline = true;
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(48, 26);
            this.tbMinute.TabIndex = 15;
            this.tbMinute.Text = "00";
            this.tbMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // tbHour
            // 
            this.tbHour.BackColor = System.Drawing.SystemColors.Menu;
            this.tbHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHour.Location = new System.Drawing.Point(2, 3);
            this.tbHour.Multiline = true;
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(48, 26);
            this.tbHour.TabIndex = 13;
            this.tbHour.Text = "00";
            this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DongHoDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHour);
            this.Name = "DongHoDemNguoc";
            this.Size = new System.Drawing.Size(152, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHour;
    }
}
