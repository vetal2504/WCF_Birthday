using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirthdayService.ServiceReferenceWeb;

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
            var client = new WebBirthdaySoapClient();
            client.AddData(textBox_name.Text, textBox_date.Text);
        }
    }
}
