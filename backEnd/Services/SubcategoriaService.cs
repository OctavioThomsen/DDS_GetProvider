using backEnd.Models;
using backEnd.Helpers;
using System.Data.SqlClient;

namespace backEnd.Services
{
    public class SubcategoriaService
    {
        public async Task<List<Subcategoria>> GetSubcategorias()
        {
            List<Subcategoria> listaSubcategorias = new List<Subcategoria>();

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
                        subcategoria.ID_CATEGORIA = (int)sqlDataReader["ID_CATEGORIA"];

                        listaSubcategorias.Add(subcategoria);
                    }
                }
            }
            return listaSubcategorias;
        }
    }
}
