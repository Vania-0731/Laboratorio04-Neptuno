using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;


namespace Laboratorio04
{
    /// <summary>
    /// Lógica de interacción para ListadoCategorias.xaml
    /// </summary>
    public partial class ListadoCategorias : Window
    {
        string connectionString = Conexion.Conectar();
        public ListadoCategorias()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("usp_ListarCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        idcategoria = (int)dr["idcategoria"],
                        nombrecategoria = dr["nombrecategoria"].ToString(),
                        descripcion = dr["descripcion"].ToString()
                    });
                }
            }
            dgCategorias.ItemsSource = lista;
        }
    }
}
