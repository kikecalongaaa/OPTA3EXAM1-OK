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

namespace ExamenP.forms
{
    public partial class FRMCuentas : Form
    {
        public FRMCuentas()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=panas;Database=CooperativaExamen;");

            conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from cuentas;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                GRIDCUENTA.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                GRIDCUENTA.DataSource = dt;

            }
            comm.Dispose();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FCuentas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            boxcosto.Enabled = true;
            boxestado.Enabled = true;
            boxmoneda.Enabled = true;
            boxnrocontrato.Enabled = true;
            boxprom.Enabled = true;
            boxsaldo.Enabled = true;
            boxtipcuent.Enabled = true;
            BOXCUENTA.Enabled = true;
            BOXFECHAALTA.Enabled = true;
            Boxnrocuenta.Enabled = true;
            bool nuevo;
            nuevo = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOXCUENTA_TextChanged(object sender, EventArgs e)
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


            string consulta = "INSERT INTO cuentas ( fechaalta, nrocuenta, tipocuenta, saldo , estado, nrocontrato, costomantenimiento, promedioacreditacion, moneda, estado1  ) VALUES ( @valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7, @valor8, @valor9, @valor10 );";

            comm.CommandText = consulta;

            // Asigna valores a los parámetros
            comm.Parameters.AddWithValue("@valor1", boxcosto.Text); // Reemplaza valor1 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor2", boxestado.Text); // Reemplaza valor2 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor3", boxmoneda.Text);// Reemplaza valor3 con el valor que desees inserta
            comm.Parameters.AddWithValue("@valor4", boxnrocontrato.Text); // Reemplaza valor4 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor5", boxprom.Text); // Reemplaza valor5 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor6", boxsaldo.Text);// Reemplaza valor6 con el valor que desees inserta
            comm.Parameters.AddWithValue("@valor7", boxtipcuent.Text); // Reemplaza valor7 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor8", BOXCUENTA.Text); // Reemplaza valor8 con el valor que desees insertar
            comm.Parameters.AddWithValue("@valor9", BOXFECHAALTA.Text);
            comm.Parameters.AddWithValue("@valor10", Boxnrocuenta.Text); // Reemplaza valor7 con el valor que desees insertar
           
            

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
    }
}
