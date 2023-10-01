using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { // Inicio

                // Capturar desde las cajas de textos los valores

                string sueldo = Sueldo_cliente.Text;
                string Nombre = this.Nombre.Text;
                string Apellido1 = this.Apellido1.Text;
                string Apellido2 = this.Apellido2.Text;
                string Rut = this.Rut.Text;
                string fechanacimiento = Fecha_nacimiento.Text;
                string profesion = Lista_profesion.Text;




                // Definir string de conexion y el comando sal

                // Autenticacion Windows
                string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                // Autenticacion SQL Server
                //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                // Instruccion SQL
                string comandoSQL = "insert cliente (sueldo_liquido,rut,nombre,apellido1,apellido2,fecha_nacimiento,profesion) values ('" + sueldo + "','" + Rut + "', '" + Nombre + "','" + Apellido1 + "',   '" + Apellido2 + "',  '" + fechanacimiento + "',  '" + profesion + "'       )";


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

            {
                // Autenticacion Windows
                string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                // Autenticacion SQL Server
                //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                // Instruccion SQL
                string comandoSQL = "UPDATE cliente SET edad = DATEDIFF(YEAR, fecha_nacimiento, GETDATE()) -  CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, fecha_nacimiento, GETDATE()), fecha_nacimiento) > GETDATE() THEN 1 ELSE 0 END ";
                string grilla = "select * from cliente";
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

                    // Crear los objetos para la conexion a la BD
                    SqlDataAdapter de = new SqlDataAdapter(grilla, con);
                    DataTable dt = new DataTable();

                    de.Fill(dt);
                    Datos_clientes.DataSource = dt;

                    // Cerra la conexion
                    con.Close();

                    // Mostrar mensaje de exito
                    MessageBox.Show("Edad calculada exitosamente ");

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
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 'K') && (e.KeyChar != 'k'))
            {
                e.Handled = true;
                return;
            }
        }

        private void sueldo_liquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int RUT = int.Parse(Rut.Text);
            string DV = Digito(RUT);
            if (DV != Dv.Text)
            {
                MessageBox.Show("RUT ingresado NO es valido");
            }
            else
            {
                MessageBox.Show("Rut  valido");
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {

        }

        private void rut_TextChanged(object sender, EventArgs e)
        {
        }
        public static
       string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private void dv_Leave(object sender, EventArgs e)
        {

        }



        private void clientes_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    // Autenticacion Windows
                    string strWindows = "server=LAPTOP\\SQLEXPRESS;database=proyecto1_taller;Integrated Security=True";
                    // Autenticacion SQL Server
                    //string strConexionSQL = "Server=SCLNTB6310766\\INSTANCIA19;Database=sistema_remuneracion;User Id=SA;Password=Aiep.2022;";

                    // Instruccion SQL
                    string grilla = "select *  from cliente";


                    // Crear los objetos para la conexion a la BD
                    SqlConnection con = new SqlConnection(strWindows);
                    DataTable dt = new DataTable();

                    // abrir conexion y ejecutar instraucicon sql
                    con.Open();
                    SqlDataAdapter de = new SqlDataAdapter(grilla, con);


                    de.Fill(dt);
                    Datos_clientes.DataSource = dt;
                    con.Close();


                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }

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
                    string comandoSQL = "select id_profesion, profesion  from profesion";


                    // Crear los objetos para la conexion a la BD
                    SqlConnection con = new SqlConnection(strWindows);
                    DataTable tbTipo = new DataTable();

                    // abrir conexion y ejecutar instraucicon sql
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(comandoSQL, con);

                    da.Fill(tbTipo);

                    // configuracion del combox 
                    Lista_profesion.DisplayMember = "profesion";
                    Lista_profesion.ValueMember = "id_profesion";

                    // poblar el combobox con el resultado del select 
                    Lista_profesion.DataSource = tbTipo;

                    // cerra la conexion
                    con.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                // Fin 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_profesion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void descripcion_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_nacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void sueldo_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fechanacimiento_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void titulo_clientes_Click(object sender, EventArgs e)
        {

        }



        private void datos_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

