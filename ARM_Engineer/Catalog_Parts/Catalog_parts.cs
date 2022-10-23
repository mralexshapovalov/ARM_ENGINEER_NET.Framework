using ARM_Engineer.Catalog_Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARM_Engineer
{
    enum Rowstate
    {
       Existed,
       New,
       Modified,
       ModifiedNow,
       Deleted

    }




    public partial class Catalog_parts : Form
    {
        Connection_in_DataBase dataBase = new Connection_in_DataBase();
        int selectRow;
        public Catalog_parts()
        {
            InitializeComponent();
        }

       
        private void CreateCulums()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("type_of", "Тип товара");
            dataGridView1.Columns.Add("cout_of", "Колличество");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew",String.Empty);


        }

        private void ReadSingleRow(DataGridView dgw,IDataRecord record) //
        {

            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetString(3),record.GetInt32(4),Rowstate.ModifiedNow);

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $" select * from parts_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.oppenConnection();

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
        }

        private void Catalog_parts_Load(object sender, EventArgs e)
        {

            CreateCulums();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox_numbers_of.Text = row.Cells[2].Value.ToString();
                textBox_supplier.Text = row.Cells[3].Value.ToString();
                textBox_Cost.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1)
        }
    }
}