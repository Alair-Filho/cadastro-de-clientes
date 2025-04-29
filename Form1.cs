using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cadastro_De_Clientes
{
    public partial class FrmCadCliente: Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }
        

           



        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using(MySqlConnection Conexao = new MySqlConnection ("Server=127.0.0.1;Port=3306;DataBase=cadastro_clientes;User=root;Password=Toji7777@@"))
            {
                Conexao.Open();
                
                using(MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento, email, telefone, data_nascimento, genero, rg, estado_civil, cep, endereco, numero_casa, bairro, cidade, estado, observacao, situacao ) VALUES(@nome, @documento, @email, @telefone, @data_nascimento, @genero, @rg, @estado_civil, @cep, @endereco, @numero_casa, @bairro, @cidade, @estado, @observacao, @situacao)";

                    cmd.Parameters.AddWithValue("@nome", TxtName.Text);
                    cmd.Parameters.AddWithValue("@documento", TxtDoc.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TxtPhone.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", TxtDate.Text);
                    cmd.Parameters.AddWithValue("@genero", "GENERO");
                    cmd.Parameters.AddWithValue("@rg", TxtRg.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CbStatus.Text);
                    cmd.Parameters.AddWithValue("@cep", TxtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbAddress.Text);
                    cmd.Parameters.AddWithValue("@numero_casa", TxtNum.Text);
                    cmd.Parameters.AddWithValue("@bairro", CbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CbCity.Text);
                    cmd.Parameters.AddWithValue("@estado", CbState.Text);
                    cmd.Parameters.AddWithValue("@observacao", TxtObs.Text);
                    cmd.Parameters.AddWithValue("@situacao", "SITAUCAO");

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("ok");
            }
        }

        private void SalvarCliente()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;DataBase=cadastro_clientes;User=root;Password=Toji7777@@"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento, email, telefone, data_nascimento, genero, rg, estado_civil, cep, endereco, numero_casa, bairro, cidade, estado, observacao, situacao ) VALUES(@nome, @documento, @email, @telefone, @data_nascimento, @genero, @rg, @estado_civil, @cep, @endereco, @numero_casa, @bairro, @cidade, @estado, @observacao, @situacao)";

                    DateTime dataConvertida = DateTime.Parse(TxtDate.Text);
                    string dataParaMySQL = dataConvertida.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@nome", TxtName.Text);
                    cmd.Parameters.AddWithValue("@documento", TxtDoc.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TxtPhone.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", dataParaMySQL);

                    if (OpMan.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Masculino");
                    }
                    else if(OpFem.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Feminino");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@genero", "Outros");
                    }

                    cmd.Parameters.AddWithValue("@rg", TxtRg.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CbStatus.Text);
                    cmd.Parameters.AddWithValue("@cep", TxtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CbAddress.Text);
                    cmd.Parameters.AddWithValue("@numero_casa", TxtNum.Text);
                    cmd.Parameters.AddWithValue("@bairro", CbBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CbCity.Text);
                    cmd.Parameters.AddWithValue("@estado", CbState.Text);
                    cmd.Parameters.AddWithValue("@observacao", TxtObs.Text);

                    if(CkSitua.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Ativo");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Cancelado");
                    }
                   
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("ok");
            }

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (Validacao() == true)
                return;

            SalvarCliente();
        }

        private bool Validacao()
        {
            //Validar campo nome
            if(TxtName.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório");
                TxtName.Focus();
                return true;
            }

            //Validar campo CPF ou CNPJ
            if(OpCpf.Checked == false && OpCnpj.Checked == false)
            {
                MessageBox.Show("Marque o tipo de documentação\rCPF ou CNPJ");
            }

            //Validar campo Documentação
            if (TxtDoc.Text == "")
            {
                MessageBox.Show("Campo documento é obrigatório");
                TxtDoc.Focus();
                return true;
            }


            return false;
        }

    }
}
