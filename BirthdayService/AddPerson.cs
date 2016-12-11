using BirthdayService.BirthdayService.WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebService;
using System.ServiceModel;

namespace BirthdayService
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (ServiceWCFClient client = new ServiceWCFClient())
            {
                client.Open();
                client.DoAddData();
                client.Close();
            }
        }
    }
}
