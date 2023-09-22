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
    public partial class FRMMovimientos : Form
    {
        public FRMMovimientos()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");
            conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from movimientos ;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridmov.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridmov.DataSource = dt;

            }
            comm.Dispose();
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FMovimientos_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");

            conn.Open();



            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            //if (decimal.TryParse(BoxSaldoA, BoxSaldoAct, BoxMontoMov, BoxCanal, BoxCtaDest, BoxCtaO, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal dBoxSaldoA, dBoxSaldoAct, dBoxMontoMov, dBoxCanal, dBoxCtaDest, dBoxCtaO))


            // if (int.TryParse(boxNrodedoc.Text, out int boxentero)) ;//de string a int}


            string consulta = "INSERT INTO movimientos ( fechamovimiento, tipomovimiento, saldoanterior, saldoactual , montomovimiento, cuentaorigen, cuentadestino, canal  ) VALUES ( @valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7, @valor8 );";

            comm.CommandText = consulta;

            // Asigna valores a los parámetros
            comm.Parameters.AddWithValue("@valor1", BoxFechadeMov.Text); // Reemplaza valor1 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor2", BoxTipodeMov.Text); // Reemplaza valor2 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor3", BoxCanal.Text);// Reemplaza valor3 con el valor que desees inserta
            comm.Parameters.AddWithValue("@valor4", BoxCtaDest.Text); // Reemplaza valor4 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor5", BoxFechadeMov.Text); // Reemplaza valor5 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor6", BoxMontoMov.Text);// Reemplaza valor6 con el valor que desees inserta
            comm.Parameters.AddWithValue("@valor7", BoxSaldoA.Text); // Reemplaza valor7 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor8", BoxSaldoAct.Text); // Reemplaza valor8 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor8", BoxTipodeMov.Text);
                
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
