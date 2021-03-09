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
    public partial class Form2 : Form
    {
        static List<Cliente> listaClientes = new List<Cliente>();
        static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        static List<Alquiler> listaAlquiler = new List<Alquiler>();
        static List<Factura> listafactura = new List<Factura>();
        public Form2()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler p = new Alquiler();
            p.Nit = txtnit.Text;
            p.Placa = txtplaca.Text;
            p.Falquiler = FAlquiler.Value.Date; // obtiene la fecha seleccionada
            p.Fdevo = FDevo.Value.Date;
            p.Recorrido = Convert.ToInt16(txtrecorrido.Text);

            listaAlquiler.Add(p);

            //..................................................
            Cliente clien = listaClientes.Find(s=> s.Nit == p.Nit);
            Vehiculo auto = listaVehiculos.Find(s => s.Placa == p.Placa);
            Factura f = new Factura();
            f.Nombre = clien.Nombre;
            f.Placa = auto.Placa;
            f.Marca = auto.Marca;
            f.Modelo = auto.Modelo;
            f.Color = auto.Color;
            f.Precio = auto.Precio;
            f.Fdevo = p.Fdevo;
            f.TotalPagar = "Q."+(auto.Precio * p.Recorrido);
            
            listafactura.Add(f);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listafactura;
            dataGridView1.Refresh();

            int mayorkm = listaAlquiler.Max(a => a.Recorrido);
            label6.Text = "" + mayorkm+" km";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            leer();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listafactura;
            dataGridView1.Refresh();
        }
    }
}
