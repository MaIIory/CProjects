using App_LocalDatabase.MyLocalDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_LocalDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersTableAdapter usersAdapter = new UsersTableAdapter();
            
            //usersAdapter.Fill(new MyLocalDatabaseDataSet().Users);

            MyLocalDatabaseDataSet.UsersDataTable users = usersAdapter.GetData();
            
            Console.Write(users.FindById(0).Name);
        }
    }
}
