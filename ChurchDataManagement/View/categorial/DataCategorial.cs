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

namespace ChurchDataManagement.View.categorial
{
    public partial class DataCategorial : Form
    {
        private DAO sqlConn;
        public DataCategorial()
        {
            InitializeComponent();
            this.sqlConn = new DAO();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (categorialNameTxt.Text.Length == 0)
            {
                MessageBox.Show(this,"Nama Kategorial belum diinput");
            }else {

                bool result = this.sqlConn.InsertCategory(
                    new Model.Category(categorialNameTxt.Text, infoTxt.Text)
                    ) ;
                if (result) {
                    categorialNameTxt.Clear();
                    infoTxt.Clear();
                    this.loadData();
                }
            }
        }

        private List<Category> categories;
        private void loadData() {
            this.sqlConn.open();
            dgvCategorial.Rows.Clear();
            this.categories = this.sqlConn.getCategories();
            foreach (Category cat in categories) {
                dgvCategorial.Rows.Add("000",cat.CategoryName,cat.Description);
                
            }
        }

        private void DataCategorial_Load(object sender, EventArgs e)
        {

            this.loadData();
        }

        private void dgvCategorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1 ) {
                Console.WriteLine("Delete Cell");
                if (this.sqlConn.DeleteCategory(categories.ElementAt(e.RowIndex).Id)) {
                    this.loadData();
                }
            }else if (e.ColumnIndex == 3 && e.RowIndex != -1){
                Console.WriteLine("Edit Cell");
            }
        }
    }
}
