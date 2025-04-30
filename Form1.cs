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
using System.Globalization;


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

        private void SalvarCliente()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;DataBase=cadastro_clientes;User=root;Password=Toji7777@@"))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento, email, telefone, data_nascimento, genero, rg, estado_civil, cep, endereco, numero_casa, bairro, cidade, estado, observacao, situacao ) VALUES(@nome, @documento, @email, @telefone, @data_nascimento, @genero, @rg, @estado_civil, @cep, @endereco, @numero_casa, @bairro, @cidade, @estado, @observacao, @situacao)";

                    

                    cmd.Parameters.AddWithValue("@nome", TxtName.Text);
                    cmd.Parameters.AddWithValue("@documento", TxtDoc.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TxtPhone.Text);

                    if(TxtDate.Text == "  /  /")
                    {
                        cmd.Parameters.AddWithValue("@data_nascimento", DBNull.Value);
                    }
                    else 
                    { 
                        cmd.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(TxtDate.Text));
                    }

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

                    cmd.CommandText = "SELECT @@IDENTITY";
                    TxtId.Text = cmd.ExecuteScalar().ToString();
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
                return true;
            }

            //Validar campo Documentação
            if (TxtDoc.Text == "")
            {
                if (OpCpf.Checked == true)
                    MessageBox.Show("Digite o CPF");
                else
                    MessageBox.Show("Digite o CNPJ");

                TxtDoc.Focus();
                return true;
            }

            //verifica marcacao do genero
            if(OpMan.Checked == false && OpFem.Checked == false && OpOthers.Checked == false )
            {
                MessageBox.Show("Selecione o genero");
                return true;
            }

            //Validar Data
            if(TxtDate.Text != "  /  /") 
            { 
                 try
                 {
                 Convert.ToDateTime(TxtDate.Text);
                 }
                 catch (Exception)
                 {
                 MessageBox.Show("Data de nascimento inválida!");
                 return true; 
                 }
            }

            return false;
        }

        private void Btnew_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente deseja limpar todos os campos?","Atenção!",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            TxtId.Text = "";
            TxtName.Text = "";

            OpCpf.Checked = false;
            OpCnpj.Checked = false;
            TxtDoc.Text = "";

            OpMan.Checked = false;
            OpFem.Checked = false;
            OpOthers.Checked = false;

            TxtRg.Text = "";
            CbStatus.Text = "";
            TxtDate.Text = "";

            TxtCep.Text = "";
            CbAddress.Text = "";
            TxtNum.Text = "";

            CbBairro.Text = "";
            CbCity.Text = "";
            CbState.Text = "";

            TxtPhone.Text = "";
            TxtEmail.Text = "";
            TxtObs.Text = "";

            CkSitua.Checked = true;

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpCpf_CheckedChanged(object sender, EventArgs e)
        {
            if(OpCpf.Checked == true)
            {
                TxtDoc.Mask = "000,000,000-00";
                TxtDoc.Focus();
            }
        }

        private void OpCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if(OpCnpj.Checked == true)
            {
                TxtDoc.Mask = "00,000,000/0000-00";
                TxtDoc.Focus();
            }
        }

        private void OpMan_CheckedChanged(object sender, EventArgs e)
        {
            TxtRg.Focus();
        }

        private void OpFem_CheckedChanged(object sender, EventArgs e)
        {
            TxtRg.Focus();
        }

        private void OpOthers_CheckedChanged(object sender, EventArgs e)
        {
            TxtRg.Focus();
        }

        private void CbStatus_Validating(object sender, CancelEventArgs e)
        {
            if(CbStatus.Text == "")
            {
                return;
            }

            if(CbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado civil válido!");
                e.Cancel = true;
            }
        }

        private void CbState_Validating(object sender, CancelEventArgs e)
        {
            if (CbState.Text == "")
            {
                return;
            }

            if (CbState.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado válido!");
                e.Cancel = true;
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            

            string textoNome = TxtName.Text;

            textoNome = textInfo.ToTitleCase(textoNome);

            textoNome = textoNome.Replace(" Das ", " das ")
                                 .Replace(" Da ", " da ")
                                 .Replace(" Dos ", " dos ")
                                 .Replace(" Do ", " do ")
                                 .Replace(" De ", " de ")
                                 .Replace(" Di ", " di ");

            TxtName.Text = textoNome;
            TxtName.SelectionStart = TxtName.TextLength;
        }

        private void CbStatus_TextChanged(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            string campoStatus = CbStatus.Text;

            campoStatus = textInfo.ToTitleCase(campoStatus);

            campoStatus = campoStatus.Replace("(A)", "(a)");

            CbStatus.Text = campoStatus;

            CbStatus.SelectionStart = CbStatus.Text.Length;
        }

        private void TxtCep_Validating(object sender, CancelEventArgs e)
        {

            if(TxtCep.Text.Length == 0)
            {
                return;
            }

            if(TxtCep.Text.Length < 8)
            {
                MessageBox.Show("CEP inclompleto!");
                e.Cancel = true;
            }
        }

        private void TxtDoc_Validating(object sender, CancelEventArgs e)
        {
            if (TxtDoc.Text == "")
            {
                return;
            }

            if (OpCpf.Checked = true && TxtDoc.Text.Replace(" ","").Length < 11)
            {
                MessageBox.Show("CPF incompleto!");
                e.Cancel = true;
            }
            if(OpCnpj.Checked == true && TxtDoc.Text.Replace(" ", "").Length < 14)
            {
                MessageBox.Show("CNPJ incompleto!");
                e.Cancel = true;
            }
        }
    }
}
