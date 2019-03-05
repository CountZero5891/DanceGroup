using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceGroup
{
    public partial class AddForm : Form
    {
        public Child ChildInfo { get; set; }

        public AddForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
             ChildInfo.ID = textBox1.Text;
             ChildInfo.Surname = textBox2.Text;
             ChildInfo.Name = textBox3.Text;
             ChildInfo.DateBirth = dateTimePicker1.Text;
             ChildInfo.Adress = textBox5.Text;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (ChildInfo!=null)
            {
                textBox1.Text = ChildInfo.ID;
                textBox2.Text = ChildInfo.Surname;
                textBox3.Text = ChildInfo.Name;
                dateTimePicker1.Text = ChildInfo.DateBirth;
                textBox5.Text = ChildInfo.Adress;
            }
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            char ch = e.KeyChar;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            }
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)||Char.IsPunctuation(e.KeyChar)|| Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }
    }
}
