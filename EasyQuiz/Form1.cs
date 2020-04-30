using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyQuiz 
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            if (Login.Visible == true) {
                Login.Visible = false;
            }
            else if (Login.Visible == false) {
                Login.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Login_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Login());
            hideSubMenu();
        }
        private void customizeDesign() {
            panelProfileSubmenu.Visible = false;
            panelProfSubMenu.Visible = false;
            panelSubSettings.Visible = false;
        }
        private void hideSubMenu() {
            if (panelProfileSubmenu.Visible == true) {
                panelProfileSubmenu.Visible = false;
            }
            if (panelProfSubMenu.Visible == true)
            {
                panelProfSubMenu.Visible = false;
            }
            if (panelSubSettings.Visible == true)
            {
                panelSubSettings.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfileSubmenu);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Registration());
            hideSubMenu();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            openChildForm(new CloseTests());
            hideSubMenu();
        }

        private void DownloadFile_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Languages_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void File_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfSubMenu);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSettings);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
