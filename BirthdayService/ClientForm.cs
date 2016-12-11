using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirthdayService;
using System.ServiceModel;

namespace BirthdayService
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            AddDataGrid();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            AddPerson newPerson = new AddPerson();
            newPerson.ShowDialog();
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddDataGrid()
        {
            //ListViewItem item = new ListViewItem(new string[] { "1111", "2222", "3333"});
            //listView1.Items.Add(item);

        }
    }
}
