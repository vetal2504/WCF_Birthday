﻿using System;
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
            using (ServiceBD.ServiceWCFClient client = new ServiceBD.ServiceWCFClient())
            {
                client.Open();
                client.DoAddData(dateTimePicker1.Value, textBox_name.Text);
                client.Close();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
