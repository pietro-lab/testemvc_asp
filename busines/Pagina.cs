using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busines
{
    public class Pagina
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public string conteudo { get; set; }

        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginaDb = new database.Pagina();

            foreach (DataRow row in paginaDb.lista().Rows)
            {
                var pagina = new Pagina();
                pagina.id = Convert.ToInt32(row["id"]);
                pagina.nome = row["nome"].ToString();
                pagina.data = Convert.ToDateTime(row["data"]);
                pagina.conteudo = row["conteudo"].ToString();

                lista.Add(pagina);
            }
            return lista;


        }

        public void Save()
        {
            new database.Pagina().Salvar(this.id, this.nome, this.data, this.conteudo);
        }

        public static Pagina BuscaPorId(int id)
        {
            var pagina = new Pagina();
            var paginaDb = new database.Pagina();

            foreach (DataRow row in paginaDb.BuscaPorId(id).Rows)
            {               
                pagina.id = Convert.ToInt32(row["id"]);
                pagina.nome = row["nome"].ToString();
                pagina.data = Convert.ToDateTime(row["data"]);
                pagina.conteudo = row["conteudo"].ToString();               
            }
            return pagina;
        }

        public static void Excluir(int id)
        {
            new database.Pagina().Excluir(id);
        }
    }
}
