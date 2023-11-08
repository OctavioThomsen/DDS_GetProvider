using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class CategoriaService
    {
        public async Task<List<Categoria>> GetCategorias()
        {
            List<Categoria> listaCategoria = new List<Categoria>();

            using (SqlCommand cmd = await DBConnectionHelper.getConnectedSqlCommand("SELECT * FROM CATEGORIA"))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync())
                {
                    while (sqlDataReader.Read())
                    {
                        Categoria categoria = new();
                        categoria.ID_CATEGORIA = (int)sqlDataReader["ID_CATEGORIA"];
                        categoria.NOMBRE = (string)sqlDataReader["NOMBRE"];

                        listaCategoria.Add(categoria);
                    }
                }
            }
            return listaCategoria;
        }
    }
}
