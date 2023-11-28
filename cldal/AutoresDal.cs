using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using clmodel;



namespace cldal
{
    public class AutoresDal
    {
        private SqlConnection _conexaoAutores;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public AutoresDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoAutores = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText = " select isnull(max(autid) , 0) + 1 as codigo " +
                "from tblautores";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(AutoresModel parAutores)

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText =
                    "insert into tblautores (autid, autnome, autpseudonimo, autobservacoes)" +
                    "values (@autid, @autnome, @autpseudonimo, @autobservacoes) ";
                _comandoSql.Parameters.Add("@autid", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@autnome", SqlDbType.VarChar).Value = parAutores.Nome;
                _comandoSql.Parameters.Add("@autpseudonimo", SqlDbType.VarChar).Value = parAutores.Pseu;
                _comandoSql.Parameters.Add("@autobservacoes", SqlDbType.VarChar).Value = parAutores.Observacoes;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(AutoresModel parAutores)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText =
                    "update tblautores" +
                    " set autnome = @autnome, " +
                    "     autpseudonimo = @autpseudonimo, " +
                    "     autobservacoes = @autobservacoes " +
                    "where autid = @autid";
                _comandoSql.Parameters.Add("@autid", SqlDbType.Int).Value = parAutores.Codigo;
                _comandoSql.Parameters.Add("@autnome", SqlDbType.VarChar).Value = parAutores.Nome;
                _comandoSql.Parameters.Add("@autpseudonimo", SqlDbType.VarChar).Value = parAutores.Pseu;
                _comandoSql.Parameters.Add("@autobservacoes", SqlDbType.VarChar).Value = parAutores.Observacoes;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void excluir(int parCodigoAutores)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText =
                    "delete from tblautores" +
                    " where autid = @autid";

                _comandoSql.Parameters.Add("@autid", SqlDbType.Int).Value = parCodigoAutores;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable listarTodos()
        {
            DataTable tabela;
            SqlDataAdapter adaptador;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText =
                    "select autid, autnome, autpseudonimo, autobservacoes" +
                    "from tblautores " +
                    "order by autnome asc ";

                tabela = new DataTable();

                adaptador = new SqlDataAdapter(_comandoSql);
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public List<AutoresModel> listarTodosArray()
        {
            List<AutoresModel> lista = new List<AutoresModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutores;
                _comandoSql.CommandText =
                    "select autid, autnome, autpseudonimo, autobservacoes" +
                    "    from tblautores " +
                    "order by autnome asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    AutoresModel item = new AutoresModel();
                    item.Codigo = Convert.ToInt32(leitor["autid"]);
                    item.Nome = leitor["autnome"].ToString();
                    item.Pseu = leitor["autpseudonimo"].ToString();
                    item.Observacoes = leitor["autobservacoes"].ToString();

                    lista.Add(item);
                }

                leitor.Close();
                return lista;


            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }
    }
}
