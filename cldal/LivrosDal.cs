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
    public class LivrosDal
    {
        private SqlConnection _conexaoLivros;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public LivrosDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoLivros = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText = " select isnull(max(livid) , 0) + 1 as codigo " +
                "from tbllivros";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserirL(LivrosModel parLivros )

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText =
                    "INSERT INTO tbllivros (livid, livnome, livanopublicacao, livisbn, livobservacoes , liediid ) " +
                    "VALUES (@livid, @livnome, @livanopublicacao, @livisbn, @livobservacoes , @liediid)";
                _comandoSql.Parameters.Add("@livid", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@livnome", SqlDbType.VarChar).Value = parLivros.Nome;
                _comandoSql.Parameters.Add("@livanopublicacao", SqlDbType.Int).Value = parLivros.AnoPu;
                _comandoSql.Parameters.Add("@livisbn", SqlDbType.Int).Value = parLivros.ISBN;
                _comandoSql.Parameters.Add("@livobservacoes", SqlDbType.VarChar).Value = parLivros.Observacoes;
                _comandoSql.Parameters.Add("@liediid", SqlDbType.Int).Value = parLivros.CodigoEDi;


                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizarL(LivrosModel parLivros)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText =
                    "update tbllivros" +
                    " set livnome = @livnome, " +
                    "     livanopublicacao = @livanopublicacao, " +
                    "     livisbn = @livisbn, " +
                    "     livobservacoes = @livobservacoes, " + 
                    "     ediid = @liediid " +
                    "where livid = @livid";
                _comandoSql.Parameters.Add("@livid", SqlDbType.Int).Value = parLivros.Codigo;
                _comandoSql.Parameters.Add("@livnome", SqlDbType.VarChar).Value = parLivros.Nome;
                _comandoSql.Parameters.Add("@livanopublicacao", SqlDbType.Int).Value = parLivros.AnoPu;
                _comandoSql.Parameters.Add("@livisbn", SqlDbType.Int).Value = parLivros.ISBN;
                _comandoSql.Parameters.Add("@livobservacoes", SqlDbType.VarChar).Value = parLivros.Codigo;
                _comandoSql.Parameters.Add("@liediid", SqlDbType.Int).Value = parLivros.CodigoEDi;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void excluirL(int parCodigoLivros )
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText =
                    "delete from tbllivros" +
                    " where livid = @livid";

                _comandoSql.Parameters.Add("@livid", SqlDbType.Int).Value = parCodigoLivros;
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
                _comandoSql.Connection =   _conexaoLivros;
                _comandoSql.CommandText =
                    "select livid, livnome , livanopublicacao , livisbn, livobservacoes , liediid" +
                    "from tbllivros " +
                    "order by livnome asc ";

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

        public List<LivrosModel> listarTodosArray()
        {
            List<LivrosModel> lista = new List<LivrosModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoLivros;
                _comandoSql.CommandText =
                    "SELECT livid, livnome , livanopublicacao , livisbn, livobservacoes , liediid" +
                    "    FROM tbllivros " +
                    "Order BY livnome ASC ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    LivrosModel item = new LivrosModel();
                    item.Codigo = Convert.ToInt32(leitor["livid"]);
                    item.Nome = leitor["livnome"].ToString();
                    item.AnoPu = Convert.ToInt32(leitor["livanopublicacao"].ToString());
                    item.ISBN = Convert.ToInt32(leitor["livisbn"].ToString()); 
                    item.Observacoes = leitor["livobservacoes"].ToString();
                    item.CodigoEDi = Convert.ToInt32(leitor["liediid"].ToString());

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
