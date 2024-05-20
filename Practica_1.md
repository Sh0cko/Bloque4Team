# 4.1 (PRACTICA 1) Practicas Csharp PicoW 
Práctica: Desarrollo de una Aplicación en C# para Control de Puerto Serial a nuestra picoW

## Objetivo:
Elaborar un programa utilizando C# con una interfaz gráfica que permita interactuar con un dispositivo PicoW a través del puerto serial.

IDE de Arduino debe de desplegar en la sección de SERIAL Display boton del lado superior derecho.

## Requisitos de la Interfaz: (ABIERTO A SUGERENCIAS)

ComboBox: Este componente permitirá al usuario seleccionar uno de los puertos seriales disponibles (del 1 al 10).
Botón 'Conectar': Al presionar este botón, el programa deberá establecer una conexión con el puerto serial seleccionado en el ComboBox.
Botón 'Desconectar': Este botón permitirá liberar el puerto serial que está actualmente en uso, cerrando la conexión establecida.
Botón 'Reset': Al ser activado, este botón deberá limpiar el contenido del TextBox TxtBoxMensaje, dejándolo listo para una nueva entrada.
TextBox 'TxtBoxMensaje': Este campo de texto será utilizado para ingresar mensajes que serán enviados y desplegados en la consola serial de un dispositivo Arduino.
Descripción Adicional:

La aplicación deberá ser capaz de manejar errores básicos relacionados con la conexión al puerto serial, como intentos de conexión a puertos no disponibles o errores al enviar datos.
La interfaz debe ser clara y amigable para el usuario, asegurando que los componentes sean accesibles y fácilmente identificables.
Esta práctica ayudará a los estudiantes a entender la comunicación entre aplicaciones de software y dispositivos de hardware a través de puertos seriales, utilizando C# y Windows Forms.

![Practica1](https://github.com/Sh0cko/Bloque4Team/assets/158124723/59cb97ba-df5c-472d-89d7-cf34c3eb09d2)

Codigo de la practica: 
```
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
```
