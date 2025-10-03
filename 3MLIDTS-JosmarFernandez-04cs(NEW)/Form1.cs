using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3MLIDTS_JosmarFernandez_04cs_NEW_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNombre.TextChanged += validarNombre;
            txtEdad.TextChanged += validarEdad;
            txtEstatura.TextChanged += validarEstatura;
            txtApellidos.TextChanged += validarApellido;
            txtTeléfono.TextChanged += validarTelefono;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txtEstatura.Clear();
            txtTeléfono.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            rbMasc.Checked = false;
            rbFem.Checked = false;
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese valores válidos para el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsTextoValido(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z\s]+$");
        }
        private bool EsEstaturaVálida(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
            //return false;
        }
        private bool EdadVálida(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
            //return false;
        }
        private bool ValidoEntero10Dígitos(string valor)
        {
            return valor.Length == 10 && valor.All(char.IsDigit);
        }
        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EdadVálida(textBox.Text))
            {
                MessageBox.Show("Ingrese un valor decimal válido para la edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEstaturaVálida(textBox.Text))
            {
                MessageBox.Show("Ingrese un valor decimal válido para la estatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese valores válidos para el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 10 && !ValidoEntero10Dígitos(textBox.Text))
            {
                MessageBox.Show("Ingrese valores válidos para el Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string apellido = txtApellidos.Text;
            string est = txtEstatura.Text;
            string num = txtTeléfono.Text;
            string edad = txtEdad.Text;
            string genero = "";
            if (rbMasc.Checked)
            {
                genero = "Hombre";
            }
            else if (rbFem.Checked)
            {

                genero = "Mujer";
            }
            if (!string.IsNullOrEmpty(txtEdad.Text) || !string.IsNullOrEmpty(txtEstatura.Text) || !string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtTeléfono.Text) || !string.IsNullOrEmpty(txtApellidos.Text))
            {
                string datos = $"Nombre:{name}\n\rApellido:{apellido}\n\r Edad:{edad} \n\r Altura: {est} \n\r Telefono: {num} \n\r Sex: {genero}";
                string ruta = @"C:\Users\craft\Documents\Códigos\txt\Datos3MAgosto2025.txt";
                bool archivoExt = File.Exists(ruta);
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    if (archivoExt)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
                MessageBox.Show(datos, "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // String datos = $"Nombre:{name}\n\rAPellido:{sur}\n\r Edad:{age} \n\r Altura: {altura} \n\r Telefono: {cel} \n\r Sex: {genero}";
                MessageBox.Show("ingrese valores a los espacios en blanco", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
