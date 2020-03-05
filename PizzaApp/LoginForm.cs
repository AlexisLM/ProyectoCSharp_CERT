using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PizzaDatabase.CreateDatabase();
        }

        private void txtusr_Enter(object sender, EventArgs e)
        {
            if (txtusr.Text == "Usuario")
            {
                txtusr.Text = "";
                txtusr.ForeColor = Color.LightGray;
            }
        }

        private void txtusr_Leave(object sender, EventArgs e)
        {
            if (txtusr.Text == "")
            {
                txtusr.Text = "Usuario";
                txtusr.ForeColor = Color.DimGray;
            }
        }



        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void errorlbl(string msj)
        {
            lblerr.Text = msj;
            lblerr.Visible = true;
        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registro = new RegisterForm();
            registro.Show();
        }

        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void txtusr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void Login()
        {
            var connection = DatabaseConnection.CreateConnection();
            var loginQuery = $"SELECT id FROM Users WHERE name = '{this.txtusr.Text}' AND password = '{CreateMD5.Hash(txtpass.Text)}'";
            var reader = DatabaseConnection.GetResultReader(connection, loginQuery);
            if (reader.Read())
            {
                this.Hide();
                var id = reader[0].ToString();
                reader.Close();
                //MessageBox.Show(id);
                Form1 ventana = new Form1(id);
                ventana.ShowDialog();
                this.Close();
            }
            else
                errorlbl("Usuario o contraseña no validos");
        }
    }
}

