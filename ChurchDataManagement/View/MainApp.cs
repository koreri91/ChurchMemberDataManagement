using ChurchDataManagement.Controller;
using ChurchDataManagement.View.categorial;
using ChurchDataManagement.View.education;
using ChurchDataManagement.View.member;
using ChurchDataManagement.View.profession;
using ChurchDataManagement.View.statusinchurch;
using ChurchDataManagement.View.statusinfamily;
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
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            new DAO().open();
        }

        private void setMDIColor()
        {
            MdiClient mdiClient;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    mdiClient = (MdiClient)ctl;
                    // Set the BackColor of the MdiClient control.
                    mdiClient.BackColor = Color.AliceBlue; ;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void displayEducation() {
            setMDIColor();
            DataEducation education = new DataEducation();
            education.MdiParent = this;
            education.Show();
        }
        private void displayMember()
        {
            setMDIColor();
            DataMember member = new DataMember(this);
            member.MdiParent = this;
            member.Show();
        }

        private void displayProfession() {
            setMDIColor();
            DataProfession profession = new DataProfession();
            profession.MdiParent = this;
            profession.Show();
        }

        private void displayCategorial() {
            setMDIColor();
            DataCategorial dataCategorial = new DataCategorial();
            dataCategorial.MdiParent = this;
            dataCategorial.Show();
        }

        private void displayStatusInFamily()
        {
            setMDIColor();
            DataStatusInFamily dataStatusInFamily = new DataStatusInFamily();
            dataStatusInFamily.MdiParent = this;
            dataStatusInFamily.Show();
        }
        private void displayPositionInChurch()
        {
            setMDIColor();
            DataPositionInChurch dataPositionInChurch = new DataPositionInChurch();
            dataPositionInChurch.MdiParent = this;
            dataPositionInChurch.Show();
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
            this.displayStatusInFamily();
        }

        private void positionInChurchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.displayPositionInChurch();
        }




    }
}
