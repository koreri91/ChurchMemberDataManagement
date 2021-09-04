
namespace ChurchDataManagement.View.statusinchurch
{
    partial class DataPositionInChurch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.infoTxt = new System.Windows.Forms.TextBox();
            this.positionNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPositionInChurch = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPositionInChurch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionInChurch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvPositionInChurch);
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
            this.groupBox1.Controls.Add(this.positionNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Pendidikan";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(229, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 48);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // infoTxt
            // 
            this.infoTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTxt.Location = new System.Drawing.Point(229, 87);
            this.infoTxt.Multiline = true;
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(748, 116);
            this.infoTxt.TabIndex = 3;
            // 
            // positionNameTxt
            // 
            this.positionNameTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionNameTxt.Location = new System.Drawing.Point(229, 35);
            this.positionNameTxt.Name = "positionNameTxt";
            this.positionNameTxt.Size = new System.Drawing.Size(674, 38);
            this.positionNameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keterangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Posisi";
            // 
            // dgvPositionInChurch
            // 
            this.dgvPositionInChurch.AllowUserToAddRows = false;
            this.dgvPositionInChurch.AllowUserToDeleteRows = false;
            this.dgvPositionInChurch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPositionInChurch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositionInChurch.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPositionInChurch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionInChurch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnPositionInChurch,
            this.ColumnInfo,
            this.ColumnActionEdit,
            this.ColumnActionDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPositionInChurch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPositionInChurch.Location = new System.Drawing.Point(15, 13);
            this.dgvPositionInChurch.MultiSelect = false;
            this.dgvPositionInChurch.Name = "dgvPositionInChurch";
            this.dgvPositionInChurch.ReadOnly = true;
            this.dgvPositionInChurch.RowHeadersWidth = 62;
            this.dgvPositionInChurch.RowTemplate.Height = 28;
            this.dgvPositionInChurch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositionInChurch.Size = new System.Drawing.Size(999, 322);
            this.dgvPositionInChurch.TabIndex = 2;
            this.dgvPositionInChurch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPositionInChurch_CellContentClick);
            // 
            // ColumnNo
            // 
            this.ColumnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.MinimumWidth = 80;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 80;
            // 
            // ColumnPositionInChurch
            // 
            this.ColumnPositionInChurch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPositionInChurch.HeaderText = "Posisi";
            this.ColumnPositionInChurch.MinimumWidth = 8;
            this.ColumnPositionInChurch.Name = "ColumnPositionInChurch";
            this.ColumnPositionInChurch.ReadOnly = true;
            this.ColumnPositionInChurch.Width = 86;
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
            this.ColumnActionEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnActionEdit.HeaderText = "";
            this.ColumnActionEdit.MinimumWidth = 100;
            this.ColumnActionEdit.Name = "ColumnActionEdit";
            this.ColumnActionEdit.ReadOnly = true;
            this.ColumnActionEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnActionEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnActionEdit.Width = 150;
            // 
            // ColumnActionDelete
            // 
            this.ColumnActionDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnActionDelete.HeaderText = "";
            this.ColumnActionDelete.MinimumWidth = 100;
            this.ColumnActionDelete.Name = "ColumnActionDelete";
            this.ColumnActionDelete.ReadOnly = true;
            this.ColumnActionDelete.Width = 150;
            // 
            // DataPositionInChurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.panel1);
            this.Name = "DataPositionInChurch";
            this.Text = "Posisi didalam Gereja";
            this.Load += new System.EventHandler(this.DataPositionInChurch_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionInChurch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox infoTxt;
        private System.Windows.Forms.TextBox positionNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPositionInChurch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPositionInChurch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionDelete;
    }
}