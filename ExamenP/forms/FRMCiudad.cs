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
    public partial class FRMCiudad : Form
    {
        public FRMCiudad()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;"); conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from ciudad ;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView2.DataSource = dt;



            }
           
        }

        private void FRMCiudades_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void FCiudad_Load(object sender, System.EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            BoxCiudad.Enabled = true;
            BOXdpto.Enabled = true;
            BoxPOSTAL.Enabled = true;
            bool nuevo;
            nuevo = true;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");
            conn.Open();



            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            if (int.TryParse(BoxPOSTAL.Text, out int valorEntero)) ;//de string a int
            string consulta = "INSERT INTO ciudad (ciudad , departamento , codigo_postal ) VALUES ( @valor1, @valor2, @valor3);";

            comm.CommandText = consulta;

            // Asigna valores a los parámetros
            comm.Parameters.AddWithValue("@valor1", BoxCiudad.Text); // Reemplaza valor1 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor2", BOXdpto.Text); // Reemplaza valor2 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor3", valorEntero);// Reemplaza valor3 con el valor que desees inserta

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

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
