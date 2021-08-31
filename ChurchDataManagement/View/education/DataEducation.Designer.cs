
namespace ChurchDataManagement.View.education
{
    partial class DataEducation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.infoTxt = new System.Windows.Forms.TextBox();
            this.eduLevelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEducation = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEducationLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvEducation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 622);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.infoTxt);
            this.groupBox1.Controls.Add(this.eduLevelTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Pendidikan";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(229, 219);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // infoTxt
            // 
            this.infoTxt.Location = new System.Drawing.Point(229, 77);
            this.infoTxt.Multiline = true;
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(748, 135);
            this.infoTxt.TabIndex = 3;
            // 
            // eduLevelTxt
            // 
            this.eduLevelTxt.Location = new System.Drawing.Point(229, 35);
            this.eduLevelTxt.Name = "eduLevelTxt";
            this.eduLevelTxt.Size = new System.Drawing.Size(674, 26);
            this.eduLevelTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keterangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tingkat Pendidikan";
            // 
            // dgvEducation
            // 
            this.dgvEducation.AllowUserToAddRows = false;
            this.dgvEducation.AllowUserToDeleteRows = false;
            this.dgvEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEducation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEducation.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnEducationLevel,
            this.ColumnInfo,
            this.ColumnActionEdit,
            this.ColumnActionDelete});
            this.dgvEducation.Location = new System.Drawing.Point(13, 13);
            this.dgvEducation.Name = "dgvEducation";
            this.dgvEducation.ReadOnly = true;
            this.dgvEducation.RowHeadersWidth = 62;
            this.dgvEducation.RowTemplate.Height = 28;
            this.dgvEducation.Size = new System.Drawing.Size(999, 322);
            this.dgvEducation.TabIndex = 0;
            // 
            // ColumnNo
            // 
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.MinimumWidth = 8;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            // 
            // ColumnEducationLevel
            // 
            this.ColumnEducationLevel.HeaderText = "Tingkat Pendidikan";
            this.ColumnEducationLevel.MinimumWidth = 8;
            this.ColumnEducationLevel.Name = "ColumnEducationLevel";
            this.ColumnEducationLevel.ReadOnly = true;
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.HeaderText = "Keterangan";
            this.ColumnInfo.MinimumWidth = 8;
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.ReadOnly = true;
            // 
            // ColumnActionEdit
            // 
            this.ColumnActionEdit.HeaderText = "";
            this.ColumnActionEdit.MinimumWidth = 8;
            this.ColumnActionEdit.Name = "ColumnActionEdit";
            this.ColumnActionEdit.ReadOnly = true;
            this.ColumnActionEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnActionEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnActionDelete
            // 
            this.ColumnActionDelete.HeaderText = "";
            this.ColumnActionDelete.MinimumWidth = 8;
            this.ColumnActionDelete.Name = "ColumnActionDelete";
            this.ColumnActionDelete.ReadOnly = true;
            // 
            // DataEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.panel1);
            this.Name = "DataEducation";
            this.Text = "Data Education";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEducationLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox infoTxt;
        private System.Windows.Forms.TextBox eduLevelTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}