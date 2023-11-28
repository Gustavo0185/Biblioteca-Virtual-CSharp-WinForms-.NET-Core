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
    public class AutLivDal
    {
        private SqlConnection _conexaoAutLiv;
        private SqlCommand _comandoSql;
        private Conexao _conexaoBanco;

        public AutLivDal()
        {
            _conexaoBanco = new Conexao();
            _conexaoAutLiv = _conexaoBanco.obterConexao();
        }


        public void inserir(AutLivModel parAutLiv)

        {

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutLiv;
                _comandoSql.CommandText =
                    "insert into tblautliv " +
                    "values (@Clivid, @Cautid) ";
                _comandoSql.Parameters.Add("@Clivid", SqlDbType.Int).Value = parAutLiv.CodLiv;
                _comandoSql.Parameters.Add("@Cautid", SqlDbType.Int).Value = parAutLiv.CodAut;
                _comandoSql.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(AutLivModel parAutLiv)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutLiv;
                _comandoSql.CommandText =
                    "update tblautliv" +
                    " set Cautid = @Cautid , " +
                    "     Clivid = @Clivid  , " +
                    "where Cautid = @Cautid";

                _comandoSql.Parameters.Add("@Cautid", SqlDbType.Int).Value = parAutLiv.CodAut;
                _comandoSql.Parameters.Add("@Clivid", SqlDbType.Int).Value = parAutLiv.CodLiv;
                _comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void excluir(int parCodigoAutLiv)
        {
            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutLiv;
                _comandoSql.CommandText =
                    "delete from tblautliv" +
                    " where Cautid = @Cautid";


                _comandoSql.Parameters.Add("@Cautid", SqlDbType.Int).Value = parCodigoAutLiv;
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
                _comandoSql.Connection = _conexaoAutLiv;
                _comandoSql.CommandText =
                    "select Cautid , Clivid " +
                    "from tblautliv " +
                    "order by Cautid asc ";

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

        public List<AutLivModel> listarTodosArray()
        {
            List<AutLivModel> lista = new List<AutLivModel>();
            SqlDataReader leitor;

            try
            {
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexaoAutLiv;
                _comandoSql.CommandText =
                    "select Cautid , Clivid " +
                    "    from tblautliv " +
                    "order by Clivid asc ";

                leitor = _comandoSql.ExecuteReader();
                while (leitor.Read())
                {
                    AutLivModel item = new AutLivModel();
                    item.CodAut = Convert.ToInt32(leitor["Cautid"]);
                    item.CodLiv = Convert.ToInt32(leitor["Clivid"]); 


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
