using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cadastro_De_Clientes
{
    class BancoDeDados
    {
        
        public static DataTable BuscaSQL(string ComandoSql)
        {
            DataTable dt = new DataTable();

            string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            using (MySqlConnection Conexao = new MySqlConnection(conexaoString))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;

                    using(MySqlDataAdapter DadosAdap = new MySqlDataAdapter(cmd))
                    {
                        DadosAdap.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static void CarregarComboBox(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = BancoDeDados.BuscaSQL("SELECT DISTINCT " + campo + " FROM " + tabela + " WHERE " + campo + " <> '' ");
            cb.SelectedIndex = -1;
            cb.DisplayMember = campo;

        }
    }
}
