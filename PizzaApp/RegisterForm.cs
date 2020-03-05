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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text == "Telefono")
            {
                txtmail.Text = "";
                txtmail.ForeColor = Color.LightGray;
            }
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text == "")
            {
                txtmail.Text = "Telefono";
                txtmail.ForeColor = Color.DimGray;
            }
        }

        private void txtcalle_Enter(object sender, EventArgs e)
        {
            if (txtcalle.Text == "Calle")
            {
                txtcalle.Text = "";
                txtcalle.ForeColor = Color.LightGray;
            }
        }

        private void txtcalle_Leave(object sender, EventArgs e)
        {
            if (txtcalle.Text == "")
            {
                txtcalle.Text = "Calle";
                txtcalle.ForeColor = Color.DimGray;
            }
        }

        private void txtcol_Enter(object sender, EventArgs e)
        {
            if (txtcol.Text == "Colonia")
            {
                txtcol.Text = "";
                txtcol.ForeColor = Color.LightGray;
            }
        }

        private void txtcol_Leave(object sender, EventArgs e)
        {
            if (txtcol.Text == "")
            {
                txtcol.Text = "Colonia";
                txtcol.ForeColor = Color.DimGray;
            }
        }

        private void txtcp_Enter(object sender, EventArgs e)
        {
            if (txtcp.Text == "CP")
            {
                txtcp.Text = "";
                txtcp.ForeColor = Color.LightGray;
            }
        }

        private void txtcp_Leave(object sender, EventArgs e)
        {
            if (txtcp.Text == "")
            {
                txtcp.Text = "CP";
                txtcp.ForeColor = Color.DimGray;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            var connection = DatabaseConnection.CreateConnection();
            var Int = (txtInt.Text == "Int") ? 0 : Int32.Parse(txtInt.Text);
            var Ext = (txtExt.Text == "Ext") ? 0 : Int32.Parse(txtExt.Text);
            String query = String.Format("Insert into Users(name,password,phone,suburb,postal_code,street," +
                "ext_number,int_number) values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})",
                txtusr.Text, CreateMD5.Hash(txtpass.Text), txtmail.Text, cmbBoxAlc.Text,
                txtcp.Text, txtcalle.Text, Int, Ext);
            var check = String.Format("Select * from Users where name='{0}' " +
                "and password='{1}'", txtusr.Text, CreateMD5.Hash(txtpass.Text));
            if (DatabaseConnection.ReadResult(connection, check) == "")
            {
                if (!DatabaseConnection.ExecuteCommand(connection, query))
                    errorlbl("Algo salió mal. Vuelve a intentar");
                else
                {
                    MessageBox.Show("Te has registrado con éxito", "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                errorlbl("Usuario existente");
            }


        }
        private void errorlbl(string msj)
        {
            lblerr.Text = msj;
            lblerr.Visible = true;
        }

        private void txtInt_Enter(object sender, EventArgs e)
        {
            if (txtInt.Text == "Int")
            {
                txtInt.Text = "";
                txtInt.ForeColor = Color.LightGray;
            }
        }

        private void txtInt_Leave(object sender, EventArgs e)
        {
            if (txtInt.Text == "")
            {
                txtInt.Text = "Int";
                txtInt.ForeColor = Color.DimGray;
            }
        }

        private void txtExt_Enter(object sender, EventArgs e)
        {
            if (txtExt.Text == "Ext")
            {
                txtExt.Text = "";
                txtExt.ForeColor = Color.LightGray;
            }
        }

        private void txtExt_Leave(object sender, EventArgs e)
        {
            if (txtExt.Text == "")
            {
                txtExt.Text = "Ext";
                txtExt.ForeColor = Color.DimGray;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
