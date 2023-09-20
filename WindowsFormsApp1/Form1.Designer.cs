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
            this.btnRead = new CustomControl.HoverButton();
            this.infoSV = new WindowsFormsApp1.info();
            this.dongHoBamGio1 = new CustomControl.DongHoBamGio();
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
            // dongHoBamGio1
            // 
            this.dongHoBamGio1.Location = new System.Drawing.Point(56, 167);
            this.dongHoBamGio1.Name = "dongHoBamGio1";
            this.dongHoBamGio1.Size = new System.Drawing.Size(220, 94);
            this.dongHoBamGio1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 354);
            this.Controls.Add(this.dongHoBamGio1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.infoSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private info infoSV;
        private CustomControl.HoverButton btnRead;
        private CustomControl.DongHoBamGio dongHoBamGio1;
    }
}

