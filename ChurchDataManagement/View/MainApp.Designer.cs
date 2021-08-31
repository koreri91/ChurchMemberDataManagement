
namespace ChurchDataManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusInFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionInChurchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.categorialToolStripMenuItem,
            this.educationToolStripMenuItem,
            this.professionToolStripMenuItem,
            this.statusInFamilyToolStripMenuItem,
            this.positionInChurchToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // categorialToolStripMenuItem
            // 
            this.categorialToolStripMenuItem.Name = "categorialToolStripMenuItem";
            this.categorialToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.categorialToolStripMenuItem.Text = "Kategorial";
            this.categorialToolStripMenuItem.Click += new System.EventHandler(this.categorialToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.educationToolStripMenuItem.Text = "Pendidikan";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.educationToolStripMenuItem_Click);
            // 
            // professionToolStripMenuItem
            // 
            this.professionToolStripMenuItem.Name = "professionToolStripMenuItem";
            this.professionToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.professionToolStripMenuItem.Text = "Pekerjaan";
            this.professionToolStripMenuItem.Click += new System.EventHandler(this.professionToolStripMenuItem_Click);
            // 
            // statusInFamilyToolStripMenuItem
            // 
            this.statusInFamilyToolStripMenuItem.Name = "statusInFamilyToolStripMenuItem";
            this.statusInFamilyToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.statusInFamilyToolStripMenuItem.Text = "Status Dalam Keluarga";
            this.statusInFamilyToolStripMenuItem.Click += new System.EventHandler(this.statusInFamilyToolStripMenuItem_Click);
            // 
            // positionInChurchToolStripMenuItem
            // 
            this.positionInChurchToolStripMenuItem.Name = "positionInChurchToolStripMenuItem";
            this.positionInChurchToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.positionInChurchToolStripMenuItem.Text = "Posisi Dalam Gereja";
            this.positionInChurchToolStripMenuItem.Click += new System.EventHandler(this.positionInChurchToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.memberToolStripMenuItem.Text = "Jemaat";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.exitToolStripMenuItem.Text = "Keluar";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Manajemen Data Jemaat Gereja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusInFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionInChurchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

