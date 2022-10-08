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

namespace ARM_Engineer
{
    public partial class Catalog_parts : Form
    {
        Connection_in_DataBase dataBase = new Connection_in_DataBase();

        public Catalog_parts()
        {
            InitializeComponent();
        }

        private void Catalog_parts_Load(object sender, EventArgs e)
        {

        }
    }
}
