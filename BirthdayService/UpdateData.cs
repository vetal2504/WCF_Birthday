using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirthdayService.ServiceBD;
using WebService;

namespace BirthdayService
{
    public partial class UpdateData : Form
    {
        public UpdateData()
        {
            InitializeComponent();
            setComboBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceWCFClient client = new ServiceWCFClient())
            {
                client.Open();

                Person[] list = client.DoShowData();
                foreach (var p in list)
                {
                    if (String.Compare(p.Name, textBox1.Text) == 0)
                    {
                        p.Name = textBox1.Text;
                        p.Date = DateTime.Parse(textBox2.Text);
                    }
                    comboBox1.Items.Add(p.Name);
                }
                comboBox1.SelectedItem = list[0].Name;
                ClientForm form = new ClientForm();
                form.AddDataGrid();
                client.Close();
            }

        }

        private void setComboBox()
        {
            using (ServiceWCFClient client = new ServiceWCFClient())
            {
                client.Open();

                Person[] list = client.DoShowData();
                foreach (var p in list)
                {
                    comboBox1.Items.Add(p.Name);
                }
                comboBox1.SelectedItem = list[0].Name;
                textBox1.Text = list[0].Date.ToString();
                textBox2.Text = list[0].Name.ToString();

                client.Close();
            }
        }

        public string ReturnName()
        {
            return textBox2.Text;
        }
        public string ReturnDate()
        {
            return textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
