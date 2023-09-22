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
    public partial class FRMPersona : Form
    {
        public FRMPersona()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12qwaszx;Database=postgres;");
            conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from persona ;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.DataSource = dt;


            }
        }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void FPersona_Load(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void btn_añadir_Click(object sender, EventArgs e)
            {
            BoxCelTel.Enabled = true;
            BoxCorreo.Enabled = true;
            BoxEstado.Enabled = true;
            BoxTipodeDoc.Enabled = true;
            boxape.Enabled = true;
            boxdireccion.Enabled = true;
            boxnom.Enabled = true;
            boxNrodedoc.Enabled = true;
            
            bool nuevo;
            nuevo = true;
        }

            private void btn_guardar_Click(object sender, EventArgs e)
            {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");
            conn.Open();



                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;


           // if (int.TryParse(boxNrodedoc.Text, out int boxentero)) ;//de string a int}
            if (int.TryParse(BoxEstado.Text, out int boxestadoent)) ;
            string consulta = "INSERT INTO persona ( nombre, apellido, tipodocumento, nrodocumento , direccion, celular, email, estado  ) VALUES ( @valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7, @valor8 );";

                comm.CommandText = consulta;

                // Asigna valores a los parámetros
                comm.Parameters.AddWithValue("@valor1", boxnom.Text); // Reemplaza valor1 con el valor que desees insertar
                comm.Parameters.AddWithValue("@valor2", boxape.Text); // Reemplaza valor2 con el valor que desees insertar
                comm.Parameters.AddWithValue("@valor3", boxNrodedoc.Text);// Reemplaza valor3 con el valor que desees inserta
                comm.Parameters.AddWithValue("@valor4", BoxTipodeDoc.Text); // Reemplaza valor4 con el valor que desees insertar
                comm.Parameters.AddWithValue("@valor5", boxdireccion.Text); // Reemplaza valor5 con el valor que desees insertar
                comm.Parameters.AddWithValue("@valor6", BoxCelTel.Text);// Reemplaza valor6 con el valor que desees inserta
                comm.Parameters.AddWithValue("@valor7", BoxCorreo.Text); // Reemplaza valor7 con el valor que desees insertar
                comm.Parameters.AddWithValue("@valor8", boxestadoent); // Reemplaza valor8 con el valor que desees insertar
               
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


