
using ChurchDataManagement.Controller;
using ChurchDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ChurchDataManagement.View.statusinchurch
{
   
    public partial class DataPositionInChurch : Form
    {
        private DAO sqlConn;
        public DataPositionInChurch()
        {
            InitializeComponent();
            this.sqlConn = new DAO();
        }

        private List<PositionInChurch> positionsInChurch;
        private void loadData()
        {
            this.sqlConn.open();
            dgvPositionInChurch.Rows.Clear();
            this.positionsInChurch = this.sqlConn.getPositionsInChurch();
            foreach (PositionInChurch position in positionsInChurch)
            {
                dgvPositionInChurch.Rows.Add("000", position.PositionName, position.Description, "Edit", "Hapus");
            }
        }

        private int idUpdate;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (positionNameTxt.Text.Length == 0)
            {
                MessageBox.Show(this, "Pekerjaan belum diinput");
            }
            else
            {
                bool result = false;
                if (saveBtn.Text.Equals("Simpan"))
                {
                    result = this.sqlConn.InsertPositionInChurch(
                                       new Model.PositionInChurch(positionNameTxt.Text, infoTxt.Text)
                                       );
                }
                else if (saveBtn.Text.Equals("Update"))
                {
                    result = this.sqlConn.UpdatePositionInChurch(
                                     new Model.PositionInChurch(positionNameTxt.Text, infoTxt.Text),
                                     idUpdate);
                }
                if (result)
                {
                    positionNameTxt.Clear();
                    infoTxt.Clear();
                    this.idUpdate = -1;
                    this.saveBtn.Text = "Simpan";
                    this.loadData();
                }
            }
        }

        private void dgvPositionInChurch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                if (this.sqlConn.DeletePositionInChurch(positionsInChurch.ElementAt(e.RowIndex).Id))
                {
                    this.loadData();
                }
            }
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                PositionInChurch item = positionsInChurch.ElementAt(e.RowIndex);
                this.idUpdate = item.Id;
                positionNameTxt.Text = item.PositionName;
                infoTxt.Text = item.Description;
                saveBtn.Text = "Update";
            }
        }

        private void DataPositionInChurch_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
    }
}
