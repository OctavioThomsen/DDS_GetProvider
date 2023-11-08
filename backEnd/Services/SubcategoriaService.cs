using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class SubcategoriaService
    {
        public async Task<List<Subcategoria>> GetSubcategorias()
        {
            List<Subcategoria> listaSubcategoria = new List<Subcategoria>();

            using (SqlCommand cmd = await DBConnectionHelper.getConnectedSqlCommand("SELECT * FROM SUBCATEGORIA"))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync())
                {
                    while (sqlDataReader.Read())
                    {
                        Subcategoria subcategoria = new();
                        subcategoria.ID_SUBCATEGORIA = (int)sqlDataReader["ID_SUBCATEGORIA"];
                        subcategoria.NOMBRE = (string)sqlDataReader["NOMBRE"];

                        listaSubcategoria.Add(subcategoria);
                    }
                }
            }
            return listaSubcategoria;
        }
    }
}
