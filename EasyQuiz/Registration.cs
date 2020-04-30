using EasyQuiz.Authorization;
using EasyQuiz.IOInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyQuiz
{
    public partial class Registration : Form
    {


        public Registration()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void registr_Click(object sender, EventArgs e)
        {
            if ((textBox_Name.Text.Equals("")) || (textBox_surname.Text.Equals("")) || (textBox_email.Text.Equals("")) || (textBox_login.Text.Equals("") || (textBox_password.Text.Equals(""))))
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {

                Check(textBox_Name.Text, textBox_surname.Text, textBox_email.Text, textBox_login.Text, textBox_password.Text);
                

            }
            
        }
        private void Check(string name, string surname, string email, string login, string password, bool isadmin = true)
        {
            pictureBox7.Visible = true;

            pictureBox8.Visible = true;

            pictureBox9.Visible = true;

            pictureBox10.Visible = true;

            pictureBox11.Visible = true;
            NewAdmin newAdmin11 = new NewAdmin();
            newAdmin11.setNewUser(name, surname, email, login, password, isadmin);
            //BindingList<NewAdmin> content= new BindingList<NewAdmin>() { newAdmin11 };
            new IOHttpTransfer().DoPost(newAdmin11);

        }
        private void Close(Form form1){
            System.Threading.Thread.Sleep(500);
            this.Close();
    } 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char number = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
                pictureBox2.Visible = true;
            }
            else {
                pictureBox2.Visible = false;
            }
            
        }

        private void textBox_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char number = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }
        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char number = e.KeyChar;
            if (!Regex.Match(Symbol, @"[a-zA-Z]").Success && number != 8 && !Char.IsDigit(number) && number != 64 && number != 46)
            {
                e.Handled = true;
                pictureBox4.Visible = true;
            }
            
            else
            {
                pictureBox4.Visible = false;
            }
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char number = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8 && !Char.IsDigit(number) && number != 64 && number != 46)
            {
                e.Handled = true;
                pictureBox5.Visible = true;
            }
            else
            {
                pictureBox5.Visible = false;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
                pictureBox6.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
