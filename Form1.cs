using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaDeVehículos
{
  
    public partial class Form1 : Form
    {
       static List<Cliente> listaClientes = new List<Cliente>();
       static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

       public Form1()
        {
            InitializeComponent();
        }

        private void leer()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Cliente personaTemp = new Cliente();

                personaTemp.Nit = reader.ReadLine();
                personaTemp.Nombre = reader.ReadLine();
                personaTemp.Direc = (reader.ReadLine());

                listaClientes.Add(personaTemp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();

            FileStream stream2 = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                Vehiculo Temp = new Vehiculo();

                Temp.Placa = reader2.ReadLine();
                Temp.Marca = reader2.ReadLine();
                Temp.Modelo = reader2.ReadLine();
                Temp.Color = reader2.ReadLine();
                Temp.Precio = Convert.ToInt16(reader2.ReadLine());

                listaVehiculos.Add(Temp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader2.Close();
        }
        private void Guardar()
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            FileStream stream = new FileStream("Clientes.txt", FileMode.Create, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            foreach (var p in listaClientes)
            {
                writer.WriteLine(p.Nit);
                writer.WriteLine(p.Nombre);
                writer.WriteLine(p.Direc);
            }
            //Cerrar el archivo
            writer.Close();

            FileStream stream2 = new FileStream("Vehiculos.txt", FileMode.Create, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer2 = new StreamWriter(stream2);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            foreach (var p in listaVehiculos)
            {
                writer2.WriteLine(p.Placa);
                writer2.WriteLine(p.Marca);
                writer2.WriteLine(p.Modelo);
                writer2.WriteLine(p.Color);
                writer2.WriteLine(p.Precio);
            }
            //Cerrar el archivo
            writer2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            cl.Nit = txtnit.Text;
            cl.Nombre = txtnombre.Text;
            cl.Direc = txtdirec.Text;

            listaClientes.Add(cl);

            Guardar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo();
            v.Placa = txtplaca.Text;
            v.Marca = txtmarca.Text;
            v.Modelo = txtmodelo.Text;
            v.Color = txtcolor.Text;
            v.Precio = Convert.ToInt16(txtprecio.Text);

            listaVehiculos.Add(v);

            Guardar();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaVehiculos;
            dataGridView2.Refresh();
        }
    }
}
