using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RegistrationMark2
{
    public partial class Form1 : Form
    {
        ToDatabase controller;
        public Form1()
        {
            InitializeComponent();
            controller = new ToDatabase(Connection.ConnStr);
        }

        #region -- Переключатели--
        private void Back_Click(object sender, EventArgs e)
        {
            RegBtn.Hide();
            Back.Hide();

            LogBtn.Show();
            Btn.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            RegBtn.Show();
            Back.Show();

            LogBtn.Hide();
            Btn.Hide();
        }
        #endregion

        private void RegBtn_Click(object sender, EventArgs e)
        {
            string Login = LogBox.Text;     Login = Login.Replace(" ", "");
            string Password = PasBox.Text; Password = Password.Replace(" ", "");
            
            CodePass.CreateHash(Login, Password);
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            string Login = LogBox.Text; Login = Login.Replace(" ", "");
            string Password = PasBox.Text; Password = Password.Replace(" ", "");

            ToDatabase Transfer = new ToDatabase(Connection.ConnStr);
            Transfer.Inspect(Login, Password);
        }
    }
}
