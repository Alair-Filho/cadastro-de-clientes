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
using System.IO;
using System.CodeDom;
using System.Configuration;


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
        string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        string PastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";

        private void SalvarCliente()
        {
            using (MySqlConnection Conexao = new MySqlConnection(conexaoString))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    if (TxtId.Text == "")
                    {
                        cmd.CommandText = "INSERT INTO clientes(nome,documento, email, telefone, data_nascimento, genero, rg, estado_civil, cep, endereco, numero_casa, bairro, cidade, estado, observacao, situacao ) VALUES(@nome, @documento, @email, @telefone, @data_nascimento, @genero, @rg, @estado_civil, @cep, @endereco, @numero_casa, @bairro, @cidade, @estado, @observacao, @situacao)";
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE clientes SET nome = @nome, documento = @documento, email = @email, telefone = @telefone, data_nascimento = @data_nascimento, genero = @genero, rg = @rg, estado_civil = @estado_civil, cep = @cep, endereco = @endereco, numero_casa = @numero_casa, bairro = @bairro, cidade = @cidade, estado = @estado, observacao = @observacao, situacao = @situacao WHERE id = " + TxtId.Text;
                    }



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

                    if(TxtId.Text == "")
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        TxtId.Text = cmd.ExecuteScalar().ToString();
                    }
                    
                }

                Funcoes.MsgAviso("Cadastro realizado com sucesso!");
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
                Funcoes.MsgAlerta("Campo nome é obrigatório");
                TxtName.Focus();
                return true;
            }

            //Validar campo CPF ou CNPJ
            if(OpCpf.Checked == false && OpCnpj.Checked == false)
            {
                Funcoes.MsgAlerta("Marque o tipo de documentação\rCPF ou CNPJ");
                return true;
            }

            //Validar campo Documentação
            if (TxtDoc.Text == "")
            {
                if (OpCpf.Checked == true)
                    Funcoes.MsgAlerta("Digite o CPF");
                else
                    Funcoes.MsgAlerta("Digite o CNPJ");

                TxtDoc.Focus();
                return true;
            }

            //verifica marcacao do genero
            if(OpMan.Checked == false && OpFem.Checked == false && OpOthers.Checked == false )
            {
                Funcoes.MsgAlerta("Selecione o genero");
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
                 Funcoes.MsgErro("Data de nascimento inválida!");
                 return true; 
                 }
            }

            return false;
        }

        private void Btnew_Click(object sender, EventArgs e)
        {
            if(Funcoes.Pergunta("Deseja Realmente Limpar todos os Campos?") == false)
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
            BtSave.Text = "Salvar";

            imgCliente.Image = Properties.Resources.avatar_icon;

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
                Funcoes.MsgErro("Selecione um estado civil válido!");
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
                Funcoes.MsgErro("Selecione um estado válido!");
                e.Cancel = true;
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(TxtName);
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
                Funcoes.MsgErro("CEP inclompleto!");
                e.Cancel = true;
            }
        }

        private void TxtDoc_Validating(object sender, CancelEventArgs e)
        {
            if (TxtDoc.Text == "")
            {
                return;
            }

            if (OpCpf.Checked == true && TxtDoc.Text.Replace(" ","").Length < 11)
            {
                Funcoes.MsgErro("CPF incompleto!");
                e.Cancel = true;
            }
            if(OpCnpj.Checked == true && TxtDoc.Text.Replace(" ", "").Length < 14)
            {
               Funcoes.MsgErro("CNPJ incompleto!");
                e.Cancel = true;
            }
        }

        private void CbAddress_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(CbAddress);
        }

        private void CbBairro_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(CbBairro);
        }

        private void CbCity_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(CbCity);
        }

        private void CbState_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(CbState);
        }

        private void BtAddImage_Click(object sender, EventArgs e)
        {
            if(TxtId.Text == "")
            {
                Funcoes.MsgErro("Salve os dados do cliente primeiro");
                return;
            }

            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";

            if (caixa.ShowDialog() == DialogResult.OK)
            {
                imgCliente.Image = Image.FromFile(caixa.FileName);

                File.Copy(caixa.FileName,PastaFotos + TxtId.Text + ".png");
            }

            
        }

        private void BtDeletePhoto_Click(object sender, EventArgs e)
        {
            if(TxtId.Text == "")
            {
                Funcoes.MsgErro("Nenhuma imagem enontrada para Remoção");
                return;
            }
            if(File.Exists(PastaFotos + TxtId.Text + ".png") == false)
            {
                Funcoes.MsgErro("Nenhuma imagem enontrada para Remoção");
                return;
            }

            if(Funcoes.Pergunta("Deseja realmente remover a foto de perfil?") == false)
            {
                return;
            }

            imgCliente.Image = Properties.Resources.avatar_icon;

            File.Delete(PastaFotos + TxtId.Text + ".png");
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
                return;

            BtSave.Text = "Atualizar";

            using(MySqlConnection Conexao = new MySqlConnection(conexaoString))
            {
                Conexao.Open();
                using(MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM clientes WHERE id = {TxtId.Text}";

                    DataTable dt = new DataTable();

                    using (MySqlDataAdapter DadosAdap = new MySqlDataAdapter(cmd))
                    {
                        DadosAdap.Fill(dt);

                        TxtName.Text = dt.Rows[0]["nome"].ToString();

                        if (dt.Rows[0]["documento"].ToString().Length == 11)
                        {
                            OpCpf.Checked = true;
                        }
                        else
                        {
                            OpCnpj.Checked = true;
                        }
                        TxtDoc.Text = dt.Rows[0]["documento"].ToString();

                        TxtEmail.Text = dt.Rows[0]["email"].ToString();
                        TxtPhone.Text = dt.Rows[0]["telefone"].ToString();
                        TxtDate.Text = dt.Rows[0]["data_nascimento"].ToString();

                        if (dt.Rows[0]["genero"].ToString() == "Masculino")
                        {
                            OpMan.Checked = true;
                        }
                        else if (dt.Rows[0]["genero"].ToString() == "Feminino")
                        {
                            OpFem.Checked = true;
                        }
                        else
                        {
                            OpOthers.Checked = true;
                        }

                        TxtRg.Text = dt.Rows[0]["rg"].ToString();
                        CbStatus.Text = dt.Rows[0]["estado_civil"].ToString();
                        TxtCep.Text = dt.Rows[0]["cep"].ToString();
                        CbAddress.Text = dt.Rows[0]["endereco"].ToString();
                        TxtNum.Text = dt.Rows[0]["numero_casa"].ToString();
                        CbBairro.Text = dt.Rows[0]["bairro"].ToString();
                        CbCity.Text = dt.Rows[0]["cidade"].ToString();
                        TxtObs.Text = dt.Rows[0]["observacao"].ToString();

                        if (dt.Rows[0]["situacao"].ToString() == "Ativo")
                        {
                            CkSitua.Checked = true;
                        }
                        else
                        {
                            CkSitua.Checked = false;
                        }

                        if (File.Exists(PastaFotos + TxtId.Text + ".png"))
                        {
                            imgCliente.Image = Image.FromFile(PastaFotos + TxtId.Text + ".png");
                        }
                        else
                        {
                            imgCliente.Image = Properties.Resources.avatar_icon;
                        }
                    }
                }
            }
        }
    }
}
