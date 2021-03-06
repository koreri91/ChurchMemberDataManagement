using ChurchDataManagement.Controller;
using ChurchDataManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchDataManagement.View.profession
{
    public partial class DataProfession : Form
    {
        private DAO sqlConn;
        public DataProfession()
        {
            InitializeComponent();
            this.sqlConn = new DAO();
        }

        private List<Profession> professions;
        private void loadData()
        {
            this.sqlConn.open();
            dgvProfession.Rows.Clear();
            this.professions = this.sqlConn.getProfessions();
            foreach (Profession profession in professions)
            {
                dgvProfession.Rows.Add("000",profession.Title,profession.Description, "Edit", "Hapus");
            }
        }

        private int idUpdate;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (professionTxt.Text.Length == 0)
            {
                MessageBox.Show(this, "Pekerjaan belum diinput");
            }
            else
            {
                bool result = false;
                if (saveBtn.Text.Equals("Simpan"))
                {
                    result = this.sqlConn.InsertProfession(
                                       new Model.Profession(professionTxt.Text, infoTxt.Text)
                                       );
                }
                else if (saveBtn.Text.Equals("Update"))
                {
                    result = this.sqlConn.UpdateProfession(
                                     new Model.Profession(professionTxt.Text, infoTxt.Text),
                                     idUpdate);
                }
                if (result)
                {
                    professionTxt.Clear();
                    infoTxt.Clear();
                    this.idUpdate = -1;
                    this.saveBtn.Text = "Simpan";
                    this.loadData();
                }
            }
        }

        private void dgvProfession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Console.WriteLine("Delete Cell");
                if (this.sqlConn.DeleteProfession(professions.ElementAt(e.RowIndex).Id))
                {
                    this.loadData();
                }
            }
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                Console.WriteLine("Edit Cell");
                Profession item = professions.ElementAt(e.RowIndex);
                this.idUpdate = item.Id;
                professionTxt.Text = item.Title;
                infoTxt.Text = item.Description;
                saveBtn.Text = "Update";
            }
        }

        private void DataProfession_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
    }
}
