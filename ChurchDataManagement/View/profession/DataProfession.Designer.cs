
namespace ChurchDataManagement.View.profession
{
    partial class DataProfession
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
            this.professionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProfession = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfession)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvProfession);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 622);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.infoTxt);
            this.groupBox1.Controls.Add(this.professionTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Pekerjaan";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(229, 219);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // infoTxt
            // 
            this.infoTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTxt.Location = new System.Drawing.Point(229, 89);
            this.infoTxt.Multiline = true;
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(748, 123);
            this.infoTxt.TabIndex = 3;
            // 
            // professionTxt
            // 
            this.professionTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professionTxt.Location = new System.Drawing.Point(229, 35);
            this.professionTxt.Name = "professionTxt";
            this.professionTxt.Size = new System.Drawing.Size(674, 38);
            this.professionTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 89);
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
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pekerjaan";
            // 
            // dgvProfession
            // 
            this.dgvProfession.AllowUserToAddRows = false;
            this.dgvProfession.AllowUserToDeleteRows = false;
            this.dgvProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfession.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnProfession,
            this.ColumnInfo,
            this.ColumnActionEdit,
            this.ColumnActionDelete});
            this.dgvProfession.Location = new System.Drawing.Point(13, 13);
            this.dgvProfession.Name = "dgvProfession";
            this.dgvProfession.ReadOnly = true;
            this.dgvProfession.RowHeadersWidth = 62;
            this.dgvProfession.RowTemplate.Height = 28;
            this.dgvProfession.Size = new System.Drawing.Size(999, 322);
            this.dgvProfession.TabIndex = 0;
            this.dgvProfession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfession_CellContentClick);
            // 
            // ColumnNo
            // 
            this.ColumnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.MinimumWidth = 8;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 187;
            // 
            // ColumnProfession
            // 
            this.ColumnProfession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProfession.HeaderText = "Pekerjaan";
            this.ColumnProfession.MinimumWidth = 8;
            this.ColumnProfession.Name = "ColumnProfession";
            this.ColumnProfession.ReadOnly = true;
            this.ColumnProfession.Width = 116;
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnInfo.HeaderText = "Keterangan";
            this.ColumnInfo.MinimumWidth = 8;
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.ReadOnly = true;
            this.ColumnInfo.Width = 128;
            // 
            // ColumnActionEdit
            // 
            this.ColumnActionEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnActionEdit.HeaderText = "";
            this.ColumnActionEdit.MinimumWidth = 8;
            this.ColumnActionEdit.Name = "ColumnActionEdit";
            this.ColumnActionEdit.ReadOnly = true;
            this.ColumnActionEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnActionEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnActionEdit.Width = 29;
            // 
            // ColumnActionDelete
            // 
            this.ColumnActionDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnActionDelete.HeaderText = "";
            this.ColumnActionDelete.MinimumWidth = 8;
            this.ColumnActionDelete.Name = "ColumnActionDelete";
            this.ColumnActionDelete.ReadOnly = true;
            this.ColumnActionDelete.Width = 8;
            // 
            // DataProfession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.panel1);
            this.Name = "DataProfession";
            this.Text = "Data Profession";
            this.Load += new System.EventHandler(this.DataProfession_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox infoTxt;
        private System.Windows.Forms.TextBox professionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProfession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionDelete;
    }
}