﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using Microsoft.Reporting.WinForms;
using System.Data;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Cadastro_De_Clientes.Properties;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace Cadastro_De_Clientes
{
    public partial class FormMenuClientes : Form
    {
        public FormMenuClientes()
        {
            InitializeComponent();
            typeof(DataGridView)
                .InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgLista, new object[] { true });
        }
        private void Ações_Enter(object sender, EventArgs e)
        {

        }
        string PastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";
        private Dictionary<string, Image> cacheFotos = new Dictionary<string, Image>();


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

                string idCliente = linha.Cells["id"].Value.ToString();
                string caminhoFoto = PastaFotos + idCliente + ".png";

                if (File.Exists(caminhoFoto))
                {
                    if (!cacheFotos.ContainsKey(idCliente))
                    {
                        using (var imgTemp = Image.FromFile(caminhoFoto))
                        {
                            cacheFotos[idCliente] = new Bitmap(imgTemp); 
                        }
                    }
                    linha.Cells["foto"].Value = cacheFotos[idCliente];
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

            Rodape();

            if (dgLista.RowCount == 0)
            {
                LblNadaEncontrado.Visible = true;
            }
            else
            {
                LblNadaEncontrado.Visible = false;
            }
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
                criterio += $" AND id = {PesqId.Text} ";
            }

            if (PesqNome.Text != string.Empty)
            {
                criterio += $" AND nome LIKE '%{PesqNome.Text}%' ";
            }

            if (PesqDocumento.Text != string.Empty)
            {
                criterio += $" AND documento LIKE '%{PesqDocumento.Text}%' ";
            }

            if (PesqGenero.Text != string.Empty)
            {
                criterio += $" AND genero = '{PesqGenero.Text}' ";
            }

            if (PesqEstadoCivil.Text != string.Empty)
            {
                criterio += $" AND estado_civil = '{PesqEstadoCivil.Text}' ";
            }

            if (PesqEndereco.Text != string.Empty)
            {
                string enderecos = PesqEndereco.Text;

                criterio += $" AND (cep LIKE '%{enderecos}%' " +
                   $"OR endereco LIKE '%{enderecos}%' " +
                   $"OR numero_casa LIKE '%{enderecos}%' " +
                   $"OR bairro LIKE '%{enderecos}%' " +
                   $"OR cidade LIKE '%{enderecos}%' " +
                   $"OR estado LIKE '%{enderecos}%')";
            }

            try
            {
                DateTime dataNasc = Convert.ToDateTime(PesqDtNasc.Text);
                criterio += $" AND data_nascimento = '{dataNasc:yyy-MM-dd}'";
            }
            catch (Exception)
            {


            }

            if (PesqAtivo.Checked == true)
            {
                criterio += " AND situacao = 'Ativo' ";
            }
            else if (PesqCancelado.Checked == true)
            {
                criterio += " AND situacao = 'Cancelado' ";
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

        private void PesqTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (PesqTodos.Checked == true)
            {

                BuscarClientes();
            }
        }

        private void PesqAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (PesqAtivo.Checked == true)
            {
                BuscarClientes();
            }
        }
        private void PesqCancelado_CheckedChanged(object sender, EventArgs e)
        {
            if (PesqCancelado.Checked == true)
            {
                BuscarClientes();
            }
        }

        private void Rodape()
        {
            LblTotalLocalizado.Text = $"Total Localizado: {dgLista.RowCount}";

            int contador = 0;
            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["situacao"].Value.ToString() == "Cancelado")
                {
                    contador++;
                }
            }

            LblCancelados.Text = $"Total Cancelados: {contador}";

            LblAtivos.Text = $"Total Ativos: {(dgLista.Rows.Count - contador)}";
        }

        private void BtPdf_Click(object sender, EventArgs e)
        {
            DataTable dtClientes = BancoDeDados.BuscaSQL("SELECT * FROM clientes");

            // Usa diretamente no ReportDataSource
            ReportDataSource rds = new ReportDataSource("DataSet1", dtClientes);

            reportRelatorio.LocalReport.DataSources.Clear();
            reportRelatorio.LocalReport.DataSources.Add(rds);

            Funcoes.ImprimirPDF(reportRelatorio, "RelatorioClientes");
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
            string id = dgLista.CurrentRow.Cells["id"].Value.ToString();


            DataRow linha = BancoDeDados.BuscaSQL($"SELECT * FROM clientes WHERE id = {id} ").Rows[0];

            string foto = PastaFotos + id + ".png";
            if (File.Exists(foto) == false)
            {
                foto = $"{PastaFotos}avatar.png";
            }
            ReportParameterCollection parametros = new ReportParameterCollection
            {
                new ReportParameter("nome",linha["nome"].ToString()),
                new ReportParameter("endereco",linha["endereco"].ToString()),
                new ReportParameter("data_nascimento",linha["data_nascimento"].ToString().Replace("00:00:00","")),
                new ReportParameter("documento",linha["documento"].ToString()),
                new ReportParameter("rg",linha["rg"].ToString()),
                new ReportParameter("telefone",linha["telefone"].ToString()),
                new ReportParameter("email",linha["email"].ToString()),
                new ReportParameter("genero",linha["genero"].ToString()),
                new ReportParameter("estado_civil",linha["estado_civil"].ToString()),
                new ReportParameter("numero_casa",linha["numero_casa"].ToString()),
                new ReportParameter("bairro",linha["bairro"].ToString()),
                new ReportParameter("cidade",linha["cidade"].ToString()),
                new ReportParameter("estado",linha["estado"].ToString()),
                new ReportParameter("situacao",linha["situacao"].ToString()),
                new ReportParameter("cep",linha["cep"].ToString()),
                new ReportParameter("foto", $"File://{foto}")
            };
            Funcoes.ImprimirPDF(reportViewer1, "FichaCadastral", parametros);
        }
    }
}
