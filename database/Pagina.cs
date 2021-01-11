using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace database
{
     public class Pagina
    {
        private string sqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }
        public DataTable lista()
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string query = "select * from paginas";
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }

        }

        public void Salvar(int id, string nome, DateTime data, string conteudo)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string query = "insert into paginas(nome,data,conteudo) values('"+ nome+"','"+data.ToString("yyyy-MM-dd HH:mm:ss")+"','"+conteudo+"')";
                if (id != 0)
                {
                    query = "update paginas set nome='"+nome+"',data='"+data.ToString("yyyy-MM-dd HH:mm:ss")+"',conteudo='"+conteudo+"' where id=" + id;
                    
                }
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

                    


            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string query = "DELETE FROM paginas WHERE id =" + id;
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable BuscaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string query = "select * from paginas where id ="+ id;
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;


            }
        }
    }
}
