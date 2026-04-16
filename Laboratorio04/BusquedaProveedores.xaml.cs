using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;

namespace Laboratorio04
{
    /// <summary>
    /// Lógica de interacción para BusquedaProveedores.xaml
    /// </summary>
    public partial class BusquedaProveedores : Window
    {
        string connectionString = Conexion.Conectar();
        public BusquedaProveedores()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("usp_BuscarProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreContacto", txtContacto.Text);
                cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        nombreCompañia = dr["nombreCompañia"].ToString(),
                        nombrecontacto = dr["nombrecontacto"].ToString(),
                        ciudad = dr["ciudad"].ToString(),
                        pais = dr["pais"].ToString()
                    });
                }
            }
            dgProveedores.ItemsSource = lista;
        }
    }
}
