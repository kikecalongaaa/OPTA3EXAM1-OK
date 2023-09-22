using ExamenP.ConexionPGADMIN;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenP.forms
{
    public partial class FRMCliente : Form
    {
        public FRMCliente()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");
            conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from cliente ;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView3.DataSource = dt;

            }
            comm.Dispose();
            conn.Close();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxFechaIngr.Enabled = true;
           
            BoxCali.Enabled = true;
            Boxestado.Enabled = true;
            bool nuevo;
            nuevo = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");
            conn.Open();



            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            //if (decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorDecimal1))
            // if (int.TryParse(boxIDP.Text,out int BoxIDPEnt)) ; //de string a int
            string consulta = "INSERT INTO cliente ( fechaingreso, calificacion, estado ) VALUES ( @valor1, @valor2, @valor3 );";

            comm.CommandText = consulta;

            // Asigna valores a los parámetros
            comm.Parameters.AddWithValue("@valor1", boxFechaIngr.Text); // Reemplaza valor1 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor2", Boxestado.Text); // Reemplaza valor2 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor3", BoxCali.Text); // Reemplaza valor2 con el valor que desees insertar
           // comm.Parameters.AddWithValue("@valor4", BoxIDPEnt);// Reemplaza valor3 con el valor que desees inserta

            Console.WriteLine("Inserción exitosa");

            int filasAfectadas = comm.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                Console.WriteLine("Inserción exitosa");
            }
            else
            {
                Console.WriteLine("La inserción no tuvo éxito");
            }

            comm.Dispose();
            conn.Close();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
