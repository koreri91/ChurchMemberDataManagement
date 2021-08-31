
namespace ChurchDataManagement.View.member
{
    partial class DataMember
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addMember = new System.Windows.Forms.Button();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActionEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnActionDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.addMember);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 595);
            this.panel1.TabIndex = 0;
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMember.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnCategorialName,
            this.ColumnInfo,
            this.ColumnActionEdit,
            this.ColumnActionDelete});
            this.dgvMember.Location = new System.Drawing.Point(13, 22);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.Size = new System.Drawing.Size(788, 513);
            this.dgvMember.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jumlah Member";
            // 
            // addMember
            // 
            this.addMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addMember.Location = new System.Drawing.Point(13, 545);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(113, 40);
            this.addMember.TabIndex = 3;
            this.addMember.Text = "Tambah";
            this.addMember.UseVisualStyleBackColor = true;
            // 
            // ColumnNo
            // 
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.MinimumWidth = 8;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.Width = 150;
            // 
            // ColumnCategorialName
            // 
            this.ColumnCategorialName.HeaderText = "Name";
            this.ColumnCategorialName.MinimumWidth = 8;
            this.ColumnCategorialName.Name = "ColumnCategorialName";
            this.ColumnCategorialName.Width = 150;
            // 
            // ColumnInfo
            // 
            this.ColumnInfo.HeaderText = "Keterangan";
            this.ColumnInfo.MinimumWidth = 8;
            this.ColumnInfo.Name = "ColumnInfo";
            this.ColumnInfo.Width = 150;
            // 
            // ColumnActionEdit
            // 
            this.ColumnActionEdit.HeaderText = "";
            this.ColumnActionEdit.MinimumWidth = 8;
            this.ColumnActionEdit.Name = "ColumnActionEdit";
            this.ColumnActionEdit.Width = 150;
            // 
            // ColumnActionDelete
            // 
            this.ColumnActionDelete.HeaderText = "";
            this.ColumnActionDelete.MinimumWidth = 8;
            this.ColumnActionDelete.Name = "ColumnActionDelete";
            this.ColumnActionDelete.Width = 150;
            // 
            // DataMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 595);
            this.Controls.Add(this.panel1);
            this.Name = "DataMember";
            this.Text = "Data Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnActionDelete;
    }
}