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
    public class EditorasDal
    {
        private SqlConnection _conexaoEditoras;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public EditorasDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoEditoras = _conexaoBanco.obterConexao();
        }

        private int obterProximoId()
        {
            int codigo = 0;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText = " select isnull(max(ediid) , 0) + 1 as codigo " +
                "from tbleditoras";

                codigo = int.Parse(_comandoSql.ExecuteScalar().ToString());

                return codigo;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }

        }

        public void inserir(EditorasModel parEditora)

        {
            int codigo = obterProximoId();

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText =
                    "insert into tbleditoras (ediid, edinome, edisigla, ediobservacoes)" +
                    "values (@ediid, @edinome, @edisigla, @ediobservacoes) ";
                _comandoSql.Parameters.Add("@ediid", SqlDbType.Int).Value = codigo;
                _comandoSql.Parameters.Add("@edinome", SqlDbType.VarChar).Value = parEditora.Nome;
                _comandoSql.Parameters.Add("@edisigla", SqlDbType.VarChar).Value = parEditora.Sigla;
                _comandoSql.Parameters.Add("@ediobservacoes", SqlDbType.VarChar).Value = parEditora.Observacoes;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(EditorasModel parEditora)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText =
                    "update tbleditoras" +
                    " set edinome = @edinome, " +
                    "     edisigla = @edisigla, " +
                    "     ediobservacoes = @ediobservacoes " +
                    "where ediid = @ediid";
                _comandoSql.Parameters.Add("@ediid", SqlDbType.Int).Value = parEditora.Codigo;
                _comandoSql.Parameters.Add("@edinome", SqlDbType.VarChar).Value = parEditora.Nome;
                _comandoSql.Parameters.Add("@edisigla", SqlDbType.VarChar).Value = parEditora.Sigla;
                _comandoSql.Parameters.Add("@ediobservacoes", SqlDbType.VarChar).Value = parEditora.Observacoes;
                _comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void excluir(int parCodigoEditora)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText =
                    "delete from tbleditoras" +
                    " where ediid = @ediid";

                _comandoSql.Parameters.Add("@ediid", SqlDbType.Int).Value = parCodigoEditora;
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
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText =
                    "select ediid , edinome , edisigla , ediobservacoes" +
                    "from tbleditoras " +
                    "order by edinome asc ";

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

        public List<EditorasModel> listarTodosArray()
        {
            List<EditorasModel> lista = new List<EditorasModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoEditoras;
                _comandoSql.CommandText =
                    "select ediid , edinome , edisigla , ediobservacoes" +
                    "    from tbleditoras " +
                    "order by edinome asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    EditorasModel item = new EditorasModel();
                    item.Codigo = Convert.ToInt32(leitor["ediid"]);
                    item.Nome = leitor["edinome"].ToString();
                    item.Sigla = leitor["edisigla"].ToString();
                    item.Observacoes = leitor["ediobservacoes"].ToString();

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
