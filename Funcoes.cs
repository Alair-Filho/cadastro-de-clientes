using Microsoft.Reporting.WinForms;
using System;
using System.Globalization;
using System.IO;
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
        public static void ImprimirPDF(ReportViewer report, string nomeArquivo, ReportParameterCollection p = null)
        {
            if (p != null)
                report.LocalReport.SetParameters(p);

            report.Refresh();
            report.RefreshReport();

            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = report.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                System.Diagnostics.Process.Start(nomeArquivo + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "C# Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

