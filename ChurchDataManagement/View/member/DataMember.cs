using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchDataManagement.View.member
{
    public partial class DataMember : Form
    {
        private MainApp mainApp;
        public DataMember(MainApp mainApp)
        {
            InitializeComponent();
            this.mainApp = mainApp;
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            AddMember dataMember = new AddMember();
            dataMember.MdiParent = this.mainApp;
            dataMember.Show();
        }
    }
}
