using ChurchDataManagement.Controller;
using ChurchDataManagement.View.categorial;
using ChurchDataManagement.View.education;
using ChurchDataManagement.View.member;
using ChurchDataManagement.View.profession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchDataManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new DAO().open();
        }

        private void displayEducation() {
            DataEducation education = new DataEducation();
            education.MdiParent = this;
            education.Show();
        }
        private void displayMember()
        {
            DataMember member = new DataMember();
            member.MdiParent = this;
            member.Show();
        }

        private void displayProfession() {
            DataProfession profession = new DataProfession();
            profession.MdiParent = this;
            profession.Show();
        }

        private void displayCategorial() {
            DataCategorial dataCategorial = new DataCategorial();
            dataCategorial.MdiParent = this;
            dataCategorial.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayMember();
        }

        private void categorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayCategorial();
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayEducation();
        }

        private void professionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayProfession();
        }

        private void statusInFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void positionInChurchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




    }
}
