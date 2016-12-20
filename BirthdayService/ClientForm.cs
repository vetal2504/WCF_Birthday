using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirthdayService.ServiceBD;
using System.ServiceModel;
using WebService;

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
            if(newPerson.ShowDialog() == DialogResult.OK)
            {
                newPerson.ShowDialog();
            }
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddDataGrid()
        {
            using (ServiceWCFClient client = new ServiceWCFClient())
            {
                client.Open();

                Person[] list = client.DoShowData();
                foreach (var p in list)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    //ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                    //ListViewItem.ListViewSubItem subItemNext = new ListViewItem.ListViewSubItem();
                    //item.Text = p.Id.ToString();
                    //subItem.Text = p.Date.ToString();
                    //subItemNext.Text = p.Name;
                    item.SubItems.Add(p.Date.ToString());
                    item.SubItems.Add(p.Name);
                    listView1.Items.Add(item);
                }

                client.Close();
            }

        }

        private void updatePerson_Click(object sender, EventArgs e)
        {
            UpdateData update = new UpdateData();
            update.ShowDialog();
            //using (ServiceWCFClient client = new ServiceWCFClient())
            //{
            //    client.Open();
            //    foreach (ListViewItem currentItem in listView1.SelectedItems)
            //    {

            //        string count = currentItem.Text;
            //        int number = int.Parse(count);
                    


            //        listView1.Items.Remove(currentItem);
            //        MessageBox.Show(currentItem.Text.ToString());
            //        client.DoRemoveData(currentItem.Text);

            //        //listView1.Items.Add(number.ToString(), number);
            //        ListViewItem item = new ListViewItem();
            //        ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            //        ListViewItem.ListViewSubItem subItemNext = new ListViewItem.ListViewSubItem();
            //        item.Text = number.ToString();
            //        subItem.Text = update.ReturnDate();
            //        subItemNext.Text = update.ReturnName();
            //        item.SubItems.Add(subItem);
            //        item.SubItems.Add(subItemNext);
            //        listView1.Items.Add(item);

            //        client.DoAddData(DateTime.Parse(update.ReturnDate()), update.ReturnName());
            //    }

            //    client.Close();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Remove();
                i--;
            }
            AddDataGrid();
        }

        private void removePerson_Click(object sender, EventArgs e)
        {

            using (ServiceWCFClient client = new ServiceWCFClient())
            {
                client.Open();
                foreach (ListViewItem currentItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(currentItem);
                    MessageBox.Show(currentItem.Text.ToString());
                    client.DoRemoveData(currentItem.Text);
                }

                client.Close();
            }

            
        }

    }
}
