using System;
using System.IO.Ports; // Asegúrate de importar el espacio de nombres SerialPort
using System.Windows.Forms;

namespace FormLDE
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Añadir números del 1 al 10 al ComboBox
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Cerrar la conexión serial si está abierta antes de cerrar la aplicación
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TxtBoxMensaje.Text = "";
        }

        private void ConectButton_Click(object sender, EventArgs e)
        {
            // Asigna el nombre del puerto COM directamente
            string selectedPortName = "COM"+comboBox1.Text;

            // Verifica si ya hay una conexión abierta y ciérrala
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            // Crea una nueva instancia de SerialPort
            serialPort = new SerialPort(selectedPortName);

            try
            {
                // Abre el puerto serial
                serialPort.Open();
                MessageBox.Show("Conexión establecida con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión: " + ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string selectedPortName = "COM" + comboBox1.Text;
            // Envía el texto del TxtBoxMensaje al dispositivo
            string mensaje = TxtBoxMensaje.Text;
            serialPort.WriteLine(mensaje); // Envía el mensaje por el puerto serie
        }
    }
}
