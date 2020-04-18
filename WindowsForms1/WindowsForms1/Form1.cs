using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            CreateTable create = new CreateTable();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            ReadInfo read = new ReadInfo();
            read.Read();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddInfo addInfo = new AddInfo();
            addInfo.Add(name.Text, email.Text);
        }
    }
}
