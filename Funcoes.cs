using System.Globalization;
using System.Windows.Forms;

namespace Cadastro_De_Clientes
{
    class Funcoes
    {
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgAviso(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Pergunta(string Msg)
        {
            if (MessageBox.Show(Msg, "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PriMaiuscula(Control ctr)
        {
            if (string.IsNullOrWhiteSpace(ctr.Text)) return;

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            string textoNome = ctr.Text.Trim();

            textoNome = textInfo.ToTitleCase(textoNome.ToLower());

            textoNome = textoNome.Replace(" Das ", " das ")
                                 .Replace(" Da ", " da ")
                                 .Replace(" Dos ", " dos ")
                                 .Replace(" Do ", " do ")
                                 .Replace(" De ", " de ")
                                 .Replace(" Di ", " di ");

            ctr.Text = textoNome;

            if (ctr is TextBox txt)
            {
                txt.SelectionStart = txt.TextLength;
            }
            else if (ctr is ComboBox cb)
            {
                cb.SelectionStart = cb.Text.Length;
            }
        }
    }
}

