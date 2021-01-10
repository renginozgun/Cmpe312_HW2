using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akbor_RenginOzgun_Hw2
{
    public partial class Select : Form
    {
        static string selected;
        static string[] book = new string[15];
        static int count = 0;

        public Select(string delete) // This constructor gets the deleted item from other page and deletes it from original array
        {
            array.Remove(delete);
            InitializeComponent();
        }
        public Select()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Add the book options
        {
            selected = (string)comboBox1.SelectedItem;
            if (selected == "Classics")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Picture of Dorian Gray");
                comboBox2.Items.Add(" War and Peace");
                comboBox2.Items.Add("Crime and Punishment");
            }
            if (selected == "Fantastical")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A Discovery of Witches");
                comboBox2.Items.Add("Book of Life");
                comboBox2.Items.Add("Dark Magic");

            }
            if (selected == "Fiction")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("The Queue");
                comboBox2.Items.Add("Educated");
                comboBox2.Items.Add("Dune");

            }
        }
        public static ObservableCollection<String> array = new ObservableCollection<string>();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // get selected items in an array
        {

        }
        public void removebook(string book)
        {
            array.Remove(book);
        }
        public string[] getBook // Use this method to pass the array to the next page
        {
            get
            {
                return book;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            array.Add(comboBox2.Text.ToString());

            MessageBox.Show("Book is added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // Confirm and go to next page
            {

                this.Hide();
                Form book = new BookList();
                book.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Select_Load(object sender, EventArgs e)
        {
         
        }
    }
}
