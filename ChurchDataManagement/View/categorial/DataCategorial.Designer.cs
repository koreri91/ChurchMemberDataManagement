
namespace ChurchDataManagement.View.categorial
{
    partial class DataCategorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.infoTxt = new System.Windows.Forms.TextBox();
            this.categorialNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategorial = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvCategorial);
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
            this.groupBox1.Controls.Add(this.categorialNameTxt);
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
            // categorialNameTxt
            // 
            this.categorialNameTxt.Location = new System.Drawing.Point(229, 35);
            this.categorialNameTxt.Name = "categorialNameTxt";
            this.categorialNameTxt.Size = new System.Drawing.Size(674, 26);
            this.categorialNameTxt.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kategorial";
            // 
            // dgvCategorial
            // 
            this.dgvCategorial.AllowUserToAddRows = false;
            this.dgvCategorial.AllowUserToDeleteRows = false;
            this.dgvCategorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorial.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCategorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnCategorialName,
            this.ColumnInfo,
            this.ColumnActionEdit,
            this.ColumnActionDelete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorial.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCategorial.Location = new System.Drawing.Point(13, 13);
            this.dgvCategorial.Name = "dgvCategorial";
            this.dgvCategorial.ReadOnly = true;
            this.dgvCategorial.RowHeadersWidth = 62;
            this.dgvCategorial.RowTemplate.Height = 28;
            this.dgvCategorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorial.Size = new System.Drawing.Size(999, 322);
            this.dgvCategorial.TabIndex = 0;
            this.dgvCategorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorial_CellContentClick);
            // 
            // ColumnNo
            // 
            this.ColumnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.MinimumWidth = 25;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 70;
            // 
            // ColumnCategorialName
            // 
            this.ColumnCategorialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCategorialName.HeaderText = "Nama Kategorial";
            this.ColumnCategorialName.MinimumWidth = 8;
            this.ColumnCategorialName.Name = "ColumnCategorialName";
            this.ColumnCategorialName.ReadOnly = true;
            this.ColumnCategorialName.Width = 149;
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInfo.HeaderText = "Keterangan";
            this.ColumnInfo.MinimumWidth = 8;
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.ReadOnly = true;
            // 
            // ColumnActionEdit
            // 
            this.ColumnActionEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnActionEdit.HeaderText = "";
            this.ColumnActionEdit.MinimumWidth = 100;
            this.ColumnActionEdit.Name = "ColumnActionEdit";
            this.ColumnActionEdit.ReadOnly = true;
            this.ColumnActionEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnActionEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnActionEdit.Text = "Edit";
            this.ColumnActionEdit.UseColumnTextForButtonValue = true;
            // 
            // ColumnActionDelete
            // 
            this.ColumnActionDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnActionDelete.HeaderText = "";
            this.ColumnActionDelete.MinimumWidth = 100;
            this.ColumnActionDelete.Name = "ColumnActionDelete";
            this.ColumnActionDelete.ReadOnly = true;
            this.ColumnActionDelete.Text = "Hapus";
            this.ColumnActionDelete.UseColumnTextForButtonValue = true;
            // 
            // DataCategorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.panel1);
            this.Name = "DataCategorial";
            this.Text = "Data Categorial";
            this.Load += new System.EventHandler(this.DataCategorial_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox infoTxt;
        private System.Windows.Forms.TextBox categorialNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionDelete;
    }
}