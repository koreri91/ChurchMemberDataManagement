using ChurchDataManagement.Controller;
using ChurchDataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChurchDataManagement.View.education
{
    public partial class DataEducation : Form
    {
        private DAO sqlConn;
        public DataEducation()
        {
            InitializeComponent();
            this.sqlConn = new DAO();
        }

        private List<Education> educations;
        private void loadData()
        {
            this.sqlConn.open();
            dgvEducation.Rows.Clear();
            this.educations = this.sqlConn.getEducations();
            foreach (Education edu in educations)
            {
                dgvEducation.Rows.Add("000", edu.EducationLevel, edu.Description,"Edit","Hapus");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(eduLevelTxt.Text.Length == 0)
            {
                MessageBox.Show(this, "Tingkat Pendidikan belum diinput");
            }else
            {
                bool result = false;
                if (saveBtn.Text.Equals("Simpan"))
                {
                    result = this.sqlConn.InsertEducation(
                                       new Model.Education(eduLevelTxt.Text, infoTxt.Text)
                                       );
                }
                else if (saveBtn.Text.Equals("Update"))
                {
                    result = this.sqlConn.UpdateEducation(
                                     new Model.Education(eduLevelTxt.Text, infoTxt.Text),
                                     idUpdate);
                }
                if (result)
                {
                    eduLevelTxt.Clear();
                    infoTxt.Clear();
                    this.idUpdate = -1;
                    this.saveBtn.Text = "Simpan";
                    this.loadData();
                }
            }
        }
       
        private void DataEducation_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        
        private int idUpdate;

        private void dgvEducation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Console.WriteLine("Delete Cell");
                if (this.sqlConn.DeleteEducation(educations.ElementAt(e.RowIndex).Id))
                {
                    this.loadData();
                }
            }
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                Console.WriteLine("Edit Cell");
                Education item = educations.ElementAt(e.RowIndex);
                this.idUpdate = item.Id;
                eduLevelTxt.Text = item.EducationLevel;
                infoTxt.Text = item.Description;
                saveBtn.Text = "Update";
            }
        }
    }
}
