using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace Cadastro_De_Clientes
{
    public partial class FormMenuClientes : Form
    {
        public FormMenuClientes()
        {
            InitializeComponent();
        }
        private void Ações_Enter(object sender, EventArgs e)
        {

        }
        string PastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";

        private void BtAdd_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.ShowDialog();
        }

        private void FormMenuClientes_Load(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void dgLista_Sorted(object sender, EventArgs e)
        {
            ReorganizarDataGrid();
        }

        private void ReorganizarDataGrid()
        {
            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["situacao"].Value.ToString() == "Cancelado")
                {
                    linha.DefaultCellStyle.ForeColor = Color.Crimson;
                }

                if (File.Exists(PastaFotos + linha.Cells["id"].Value.ToString() + ".png"))
                {
                    linha.Cells["foto"].Value = Image.FromFile(PastaFotos + linha.Cells["id"].Value.ToString() + ".png");
                }
                else
                {
                    linha.Cells["foto"].Value = Properties.Resources.avatar_icon;
                }
            }
            dgLista.ClearSelection();
            BtEdit.Enabled = false;
            BtImprimir.Enabled = false;
        }

        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtEdit.Enabled = true;
            BtImprimir.Enabled = true;
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();

            frm.TxtId.Text = dgLista.CurrentRow.Cells["id"].Value.ToString();

            frm.ShowDialog();

            BuscarClientes();

        }

        private void BuscarClientes()
        {
            dgLista.DataSource = BancoDeDados.BuscaSQL("SELECT * FROM clientes WHERE 1 " + GerarCriterios());

            ReorganizarDataGrid();
        }

        private void PesqId_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private string GerarCriterios()
        {
            string criterio = "";
            if (PesqId.Text != string.Empty)
            {
                criterio += $" AND id = {PesqId.Text} " ;
            }

            if (PesqNome.Text != string.Empty)
            {
                criterio += $" AND nome LIKE '%{PesqNome.Text}%' ";
            }
            
            if(PesqDocumento.Text != string.Empty)
            {
                criterio += $" AND documento LIKE '%{PesqDocumento.Text}%' ";
            }

            if(PesqGenero.Text != string.Empty)
            {
                criterio += $" AND genero = '{PesqGenero.Text}' ";
            }

            if(PesqEstadoCivil.Text != string.Empty)
            {
                criterio += $" AND estado_civil = '{PesqEstadoCivil.Text}' ";
            }

            return criterio;
        }

        private void PesqNome_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void PesqDocumento_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
    }
}
