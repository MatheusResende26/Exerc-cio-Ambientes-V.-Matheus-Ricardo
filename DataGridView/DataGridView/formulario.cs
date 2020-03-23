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

namespace DataGridView
{
    public partial class formulario : Form
    {
        List<pessoa> lista = new List<pessoa>();

        public formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            sexo objsexo = new sexo();
            cmbSexo.DataSource = objsexo.listar();
            cmbSexo.ValueMember = "id";
            cmbSexo.DisplayMember = "descricao";
            txtObgNome.Visible = true;
            txtObgCPF.Visible = true;
            txtObgRG.Visible = true;
            btCadastrar.Visible = true;
        }

        private void BtcadastrarF_Click(object sender, EventArgs e)
        {
                pessoa Pessoa = new pessoa();
                Pessoa.Nome = txtNome.Text;

                sexo Sexo = new sexo();
                if (cmbSexo.SelectedIndex == 1)
                {
                    Pessoa.Sexo = "Masculino";
                }
                else
                {
                    Pessoa.Sexo = "Feminino";
                }

                Pessoa.DataNascimento = dtpDtNasc.Text;
                if (rbmS.Checked)
                {
                    Pessoa.NecessidadesEspeciais = true;
                }
                else
                {
                    Pessoa.NecessidadesEspeciais = false;
                }
                Pessoa.RG = txtRG.Text;
                Pessoa.CPF = txtCPF.Text;

                lista.Add(Pessoa);
                DataGridView1();
                limpaCampos();
            
        }
        public void limpaCampos()
        {
            txtNome.Clear();
            dtpDtNasc.Value = DateTime.Now;
            cmbSexo.Text = "";
            if (rbmS.Checked)
            {
                rbmS.Checked = false;
            }
            else
            {
                rbN.Checked = false;
            }
            txtCPF.Clear();
            txtRG.Clear();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void DataGridView1()
        {
            dgvClientes.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == "Feminino"? "Feminino" :  "Masculino",
                    lista[i].CPF,
                    lista[i].RG,
                    lista[i].NecessidadesEspeciais == false ? "Não": "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }

        }

        private void Cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<sexo> sexos = new List<sexo>();
            sexos.Add(new sexo(1, "Feminino", "F"));
            sexos.Add(new sexo(2, "Masculino", "M"));
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            int indicelinha = dgvClientes.CurrentRow.Index;

            limpaCampos();
            dgvClientes.Rows.Clear();
            lista.RemoveAt(indicelinha);
            DataGridView1();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNome.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                txtObgNome.Visible = false;
            }
            else
            {
                txtObgNome.Visible = true;
            }
            verificar();
        }
        private void mtxtrg_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtRG.Text, @"^(\d{2}.\d{3}.\d{3}-\d{1})|(\d{9})$"))
            {
                txtObgRG.Visible = false;
            }
            else
            {
                txtObgRG.Visible = true;
            }
            verificar();
        }
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCPF.Text, @"^(\d{3}.\d{3}.\d{3}-\d{2})|(\d{11})$"))
            {
                txtObgCPF.Visible = false;
            }
            else
            {
                txtObgCPF.Visible = true;
            }
            verificar();
        }
        public void verificar()
        {
            if (txtObgNome.Visible || txtObgCPF.Visible || txtObgRG.Visible)
            {
                btCadastrar.Visible = false;
            }
            else
            {
                btCadastrar.Visible = true;
            }
        }
        private void Txtpreenchersexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtpreencherCPF_TextChanged(object sender, EventArgs e)
        {

        }



        private void TxtpreencheNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtpreencherRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
