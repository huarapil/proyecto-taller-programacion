using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Solicitud_creditos : Form
    {
        public Solicitud_creditos()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lista_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Solicitud_creditos_Load(object sender, EventArgs e)
        {


            {
                { // Inicio
                    try
                    {
                        // Poblar combobox

                        // Definir string de conexion y el comando sql

                        // Autenticacion Windows
                        string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                        // Autenticacion SQL Server
                        //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                        // Instruccion SQL
                        string comandoSQL = "select nombre_credito,codigo from tipos_de_creditos";


                        // Crear los objetos para la conexion a la BD
                        SqlConnection con = new SqlConnection(strWindows);
                        DataTable tbTipo = new DataTable();

                        // abrir conexion y ejecutar instraucicon sql
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(comandoSQL, con);

                        da.Fill(tbTipo);

                        // configuracion del combox 
                        Nombre_credito.DisplayMember = "nombre_credito";
                        Nombre_credito.ValueMember = "codigo";
                        Codigo.DisplayMember = "codigo";

                        // poblar el combobox con el resultado del select 
                        Nombre_credito.DataSource = tbTipo;
                        Codigo.DataSource = tbTipo;
                        // cerra la conexion
                        con.Close();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                    // Fin }
                }


            }
            {



            }





        }

        private void monto_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void plazo_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_credito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombre_credito_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ingresar_solicitud_Click(object sender, EventArgs e)
        {
            {

                string credito = Codigo.Text;
                string plazo = Plazo_credito.Text;
                string monto = Monto_credito.Text;

                // Autenticacion Windows
                string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                // Autenticacion SQL Server
                //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                // Instruccion SQL
                string comandoSQL = "insert  creditos_solicitados (codigo,monto_solicitado,plazo_pago) values ('" + credito + "', '" + monto + "','" + plazo + "'     )";

                // Crear los objetos para la conexion a la BD
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection(strWindows);
                try
                {
                    // Abrir la conexion 
                    con.Open();

                    // Ejecutar la instrucicon SQL
                    da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand(comandoSQL, con);
                    da.InsertCommand.ExecuteNonQuery();

                    // Cerra la conexion
                    con.Close();

                    // Mostrar mensaje de exito
                    MessageBox.Show("Registro grabado exitosamente.");

                }
                catch (Exception ex)
                {
                    // en caso de algun error, mostrar el error
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State != System.Data.ConnectionState.Closed)
                        con.Close();
                }
                // Fin }
            }

            {
                string rut = Rut_cliente.Text;

                // Autenticacion Windows
                string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                // Autenticacion SQL Server
                //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                // Instruccion SQL
                string comandoSQL = " insert into creditos_clientes values ('" + rut + "')";

                // Crear los objetos para la conexion a la BD
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection(strWindows);
                try
                {
                    // Abrir la conexion 
                    con.Open();

                    // Ejecutar la instrucicon SQL
                    da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand(comandoSQL, con);
                    da.InsertCommand.ExecuteNonQuery();

                    // Cerra la conexion
                    con.Close();

                    // Mostrar mensaje de exito
                    MessageBox.Show("Registro grabado exitosamente.");

                }
                catch (Exception ex)
                {
                    // en caso de algun error, mostrar el error
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State != System.Data.ConnectionState.Closed)
                        con.Close();
                }
                // Fin } }


            }
        }

        private void rut_cliente_TextChanged(object sender, EventArgs e)
        {






        }

        private void dv_TextChanged(object sender, EventArgs e)
        {








        }
    }
}