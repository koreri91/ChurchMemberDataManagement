using ChurchDataManagement.Controller;
using ChurchDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChurchDataManagement.View.statusinfamily
{
    public partial class DataStatusInFamily : Form
    {
        private DAO sqlConn;
        public DataStatusInFamily()
        {
            InitializeComponent();
            this.sqlConn = new DAO();
        }

        private List<StatusInFamily> statuses;
        private void loadData()
        {
            this.sqlConn.open();
            dgvStatusInFamily.Rows.Clear();
            this.statuses = this.sqlConn.getStatusInFamily();
            foreach (StatusInFamily status in statuses)
            {
                dgvStatusInFamily.Rows.Add("000", status.StatusName, status.Description, "Edit", "Hapus");
            }
        }

        private int idUpdate;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (statusNameTxt.Text.Length == 0)
            {
                MessageBox.Show(this, "Pekerjaan belum diinput");
            }
            else
            {
                bool result = false;
                if (saveBtn.Text.Equals("Simpan"))
                {
                    result = this.sqlConn.InsertStatusInFamily(
                                       new Model.StatusInFamily(statusNameTxt.Text, infoTxt.Text)
                                       );
                }
                else if (saveBtn.Text.Equals("Update"))
                {
                    result = this.sqlConn.UpdateStatusInFamily(
                                     new Model.StatusInFamily(statusNameTxt.Text, infoTxt.Text),
                                     idUpdate);
                }
                if (result)
                {
                    statusNameTxt.Clear();
                    infoTxt.Clear();
                    this.idUpdate = -1;
                    this.saveBtn.Text = "Simpan";
                    this.loadData();
                }
            }
        }

        private void dgvStatusInFamily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                if (this.sqlConn.DeleteStatusInFamily(statuses.ElementAt(e.RowIndex).Id))
                {
                    this.loadData();
                }
            }
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                StatusInFamily item = statuses.ElementAt(e.RowIndex);
                this.idUpdate = item.Id;
                statusNameTxt.Text = item.StatusName;
                infoTxt.Text = item.Description;
                saveBtn.Text = "Update";
            }
        }

        private void DataStatusInFamily_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
    }
}
