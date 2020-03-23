using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class frmlogin : System.Windows.Forms.Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Txtsenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSen.Text == "123")
            {
                piccertoSen.Visible = true;
            }
            else
            {
                piccertoSen.Visible = false;
            }
            verificar();
        }

        private void Txtusuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUs.Text == "joao")
            {
                piccertoUs.Visible = true;
            }
            else
            {
                piccertoUs.Visible = false;
            }
            verificar();
        }

        public void verificar()
        {
            if (piccertoUs.Visible && piccertoSen.Visible )
            {
                btnEntrar.Visible = true;
            }
            else
            {
                btnEntrar.Visible = false;
            }
        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            formulario frm = new formulario();
            this.Hide();
            frm.Show();
        }

        private void Btnentrar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
