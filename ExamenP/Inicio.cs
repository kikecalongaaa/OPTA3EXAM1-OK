using ExamenP.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ExamenP
{
    public partial class Inicio : Form
    {
        private object fCliente;

        public Inicio()
        {
            InitializeComponent();
            ConexionPGADMIN.ConexionPG objetoConexion = new ConexionPGADMIN.ConexionPG();
            objetoConexion.establecerConexion();       //Realizamos la conexion a la BD al inicio del proyecto
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMCiudad fp = new FRMCiudad();
            fp.Show();// Para mostrar el formulario al tocar sobre Ciudades
        }

        private void btn_Movimiento_Click(object sender, EventArgs e)
        {
            FRMMovimientos fp = new FRMMovimientos();
            fp.Show();// Para visualizar el formulario Movimiento 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRMCliente fp = new FRMCliente();
            fp.Show(); //para ver el formulario cliente
                      
        }

        private static void NewMethod()
        {
            //FCliente.Show();// para visualizar el formulario Cliente 
        }

        private void button1_Click_2(object sender, EventArgs e, FRMCliente fCliente)
        {
            //FCliente fp = new FCliente();
            //fp.Show();// para visualizar el formulario Cliente 
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FRMCuentas fcuenta = new FRMCuentas();
            fcuenta.Show(); //Para Visualizar el formulario persona
        }

        private void btn_Persona_Click(object sender, EventArgs e)
        {
            FRMPersona fPersona = new FRMPersona();
            fPersona.Show(); //Para Visualizar el formulario persona
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCiudad fp = new FRMCiudad();
            fp.Show();// Para mostrar el formulario al tocar sobre Ciudades
        }

        private void movimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMMovimientos fp = new FRMMovimientos();
            fp.Show();// Para visualizar el formulario Movimiento 
        }

        private void btn_movimiento_Click_1(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCliente fp = new FRMCliente();
            fp.Show(); //para ver el formulario cliente
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCuentas fcuenta = new FRMCuentas();
            fcuenta.Show(); //Para Visualizar el formulario persona
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMPersona fPersona = new FRMPersona();
            fPersona.Show(); //Para Visualizar el formulario persona
        }
    }
}
