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
using BirthdayService.ServiceReferenceWeb;

namespace BirthdayService
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
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
            var client = new WebBirthdaySoapClient();
            //client.Ad
        }
    }
}
