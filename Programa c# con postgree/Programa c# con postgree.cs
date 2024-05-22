using conexionc_conpostgre.clases;
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

namespace conexionc_conpostgre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clases.Cconexion objetoconexion = new clases.Cconexion();
            objetoconexion.establecerConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Cconexion conexion = new Cconexion();
                NpgsqlConnection conn = conexion.establecerConexion();

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    string query = "SELECT * FROM Marca;";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    conn.Close();
                }
                {
                    string query = "SELECT * FROM Vehiculo;";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;

                    conn.Close();
                }
                {
                    string query = "SELECT * FROM Vendedor;";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView3.DataSource = table;

                    conn.Close();
                }
                {
                    string query = "SELECT * FROM Factura;";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView4.DataSource = table;

                    conn.Close();
                }
                {
                    string query = "SELECT * FROM Cliente;";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView5.DataSource = table;

                    conn.Close();
                }
                {

                }
            }

        }

       
        
            private void buttonTransferir_Click(object sender, EventArgs e)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Aquí asumimos que el DataGridView tiene columnas llamadas "Id" y "Nombre"
                textBox1.Text = selectedRow.Cells["cod_marca"].Value.ToString();
                    textBox1.Text = selectedRow.Cells["descripcion"].Value.ToString();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
           if  (dataGridView1.SelectedRows.Count > 0)
                {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Aquí asumimos que el DataGridView tiene columnas llamadas "Id" y "Nombre"
                textBox1.Text = selectedRow.Cells["cod_marca"].Value.ToString();
                textBox1.Text = selectedRow.Cells["descripcion"].Value.ToString();
            }
    }
    }
}
