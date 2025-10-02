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

namespace _3MLIDTS_JosmarFernandez_04cs_NEW_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            txtEdad.Clear();
            txtEstatura.Clear();
            txtTeléfono.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            rbMasc.Checked = false;
            rbFem.Checked = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string est = txtEstatura.Text.Trim();
            string num = txtTeléfono.Text.Trim();
            string edad = txtEdad.Text.Trim();

            string genero = rbMasc.Checked ? "Hombre" :
                            rbFem.Checked ? "Mujer" : "No especificado";

            // Validaciones
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(est) ||
                string.IsNullOrEmpty(num) ||
                string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edad, out int edadNum) || edadNum <= 0)
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(est, out float estaturaNum) || estaturaNum <= 0)
            {
                MessageBox.Show("Ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(num, out _))
            {
                MessageBox.Show("Ingrese un teléfono válido (solo números).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construcción del string
            string datos = $"Nombre: {name}\nApellido: {apellido}\nEdad: {edadNum} años\nAltura: {estaturaNum} m\nTeléfono: {num}\nGénero: {genero}";

            string ruta = @"C:\Users\craft\Documents\Códigos\txt\DatosMejorados.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine(datos);
                    writer.WriteLine(new string('-', 40)); // separador
                }

                MessageBox.Show("Datos guardados exitosamente:\n\n" + datos,
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
