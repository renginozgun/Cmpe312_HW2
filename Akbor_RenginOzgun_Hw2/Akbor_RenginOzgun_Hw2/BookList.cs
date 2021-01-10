using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Akbor_RenginOzgun_Hw2
{
    public partial class BookList : Form
    {
        Select Select = new Select();
        static string selectedbook;
        public BookList()
        {
            InitializeComponent();

            showbook();

        }
        public void showbook()
        {
            listBox1.Items.Clear();  // Show book displays the array from other page
            foreach (string element in Select.array)
            {
                     
                listBox1.Items.Add(element.ToString());
            }
        }


        private void BookList_Load(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  // go back to selection page
            this.Hide();
            Form back = new Select(selectedbook); // Send deleted book the previous page
            back.Show();
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            selectedbook = listBox1.SelectedItem.ToString();
           listBox1.Items.RemoveAt(index); //delete the items from selected index
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
