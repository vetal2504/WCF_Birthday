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

namespace BirthdayService
{
    public partial class UpdateData : Form
    {
        public UpdateData()
        {
            InitializeComponent();
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

        }

        private void AddDataList()
        {
            using (ServiceBD.ServiceWCFClient client = new ServiceBD.ServiceWCFClient())
            {
                //client.Open();

                //var list = client.DoShowData();

                //foreach (string file in client.DoShowData().)
                //{
                //    ListViewItem lvi = new ListViewItem();
                //    // установка названия файла
                //    lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                //    lvi.ImageIndex = 0; // установка картинки для файла
                //                        // добавляем элемент в ListView
                //    listView1.Items.Add(lvi);
                //}

                //client.Close();
            }
        }
    }
}
