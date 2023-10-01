using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class tipo_credito : Form
    {
        public tipo_credito()
        {
            InitializeComponent();
        }

        private void ingresar_sueldo_cliente_Click(object sender, EventArgs e)
        {
            // Inicio

            // Capturar desde las cajas de textos los valores
            string codigo = Codigo_credito.Text;
            string nombre = Nombre_credito.Text;
            string tasainteres = Tasa_interes.Text;
            string edadmaxima = Edad_maxima.Text;
            string montomaximo = Monto_maximo.Text;
            string montominimo = Monto_minimo.Text;
            string sueldominimo = Sueldo_minimo.Text;


            // Definir string de conexion y el comando sal

            // Autenticacion Windows
            string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
            // Autenticacion SQL Server
            //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

            // Instruccion SQL
            string comandoSQL = "insert tipos_de_creditos (codigo,nombre_credito,tasa_interes,edad_maxima,monto_minimo,monto_maximo,sueldo_minimo) values ('" + codigo + "','" + nombre + "','" + tasainteres + "','" + edadmaxima + "','" + montominimo + "','" + montomaximo + "','" + sueldominimo + "')";

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
            // Fin 
        }



        private void tipo_credito_Load(object sender, EventArgs e)
        {

        }





        private void Sueldo_minimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Monto_minimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void Codigo_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edad_maxima_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
