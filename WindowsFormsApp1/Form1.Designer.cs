namespace WindowsFormsApp1
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
            this.qLDSV_TCDataSet = new WindowsFormsApp1.QLDSV_TCDataSet();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new WindowsFormsApp1.QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dongHoDemNguoc1 = new CustomControl.DongHoDemNguoc();
            this.customListView1 = new CustomControl.CustomListView();
            this.kiemTraChuoi1 = new CustomControl.KiemTraChuoi();
            this.passTextBox1 = new CustomControl.PassTextBox();
            this.dongHoBamGio1 = new CustomControl.DongHoBamGio();
            this.btnRead = new CustomControl.HoverButton();
            this.infoSV = new WindowsFormsApp1.info();
            this.dongHoDemNguoc2 = new CustomControl.DongHoDemNguoc();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dongHoDemNguoc1
            // 
            this.dongHoDemNguoc1.Location = new System.Drawing.Point(82, 368);
            this.dongHoDemNguoc1.Name = "dongHoDemNguoc1";
            this.dongHoDemNguoc1.Size = new System.Drawing.Size(152, 63);
            this.dongHoDemNguoc1.TabIndex = 11;
            // 
            // customListView1
            // 
            this.customListView1.Location = new System.Drawing.Point(526, 167);
            this.customListView1.Name = "customListView1";
            this.customListView1.Size = new System.Drawing.Size(366, 238);
            this.customListView1.TabIndex = 10;
            // 
            // kiemTraChuoi1
            // 
            this.kiemTraChuoi1.ChuoiChua = false;
            this.kiemTraChuoi1.Location = new System.Drawing.Point(295, 240);
            this.kiemTraChuoi1.Name = "kiemTraChuoi1";
            this.kiemTraChuoi1.Size = new System.Drawing.Size(100, 20);
            this.kiemTraChuoi1.TabIndex = 8;
            // 
            // passTextBox1
            // 
            this.passTextBox1.Location = new System.Drawing.Point(241, 198);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(100, 20);
            this.passTextBox1.TabIndex = 7;
            // 
            // dongHoBamGio1
            // 
            this.dongHoBamGio1.Location = new System.Drawing.Point(56, 167);
            this.dongHoBamGio1.Name = "dongHoBamGio1";
            this.dongHoBamGio1.Size = new System.Drawing.Size(220, 94);
            this.dongHoBamGio1.TabIndex = 6;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(221, 118);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.hoverButton1_Click_1);
            // 
            // infoSV
            // 
            this.infoSV.Location = new System.Drawing.Point(31, 12);
            this.infoSV.Name = "infoSV";
            this.infoSV.Size = new System.Drawing.Size(428, 100);
            this.infoSV.TabIndex = 3;
            // 
            // dongHoDemNguoc2
            // 
            this.dongHoDemNguoc2.Location = new System.Drawing.Point(568, 33);
            this.dongHoDemNguoc2.Name = "dongHoDemNguoc2";
            this.dongHoDemNguoc2.Size = new System.Drawing.Size(334, 202);
            this.dongHoDemNguoc2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 583);
            this.Controls.Add(this.dongHoDemNguoc2);
            this.Controls.Add(this.dongHoDemNguoc1);
            this.Controls.Add(this.customListView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kiemTraChuoi1);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.dongHoBamGio1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.infoSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private info infoSV;
        private CustomControl.HoverButton btnRead;
        private CustomControl.DongHoBamGio dongHoBamGio1;
        private CustomControl.PassTextBox passTextBox1;
        private CustomControl.KiemTraChuoi kiemTraChuoi1;
        private System.Windows.Forms.Button button1;
        private CustomControl.CustomListView customListView1;
        private CustomControl.DongHoDemNguoc dongHoDemNguoc1;
        private CustomControl.DongHoDemNguoc dongHoDemNguoc2;
    }
}

