using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoPrimerTrimestre
{
    /// <summary>
    /// Lógica de interacción para Registro_de_Usuario.xaml
    /// </summary>
    
    public partial class Registro_de_Usuario : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public Registro_de_Usuario()
        {
            InitializeComponent();
        }

        private void registro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }

            string nombre, apellidos, dni, sexo;
            double altura;
            double peso;
            String fecha;            

            nombre = nombretxt.Text;       
            apellidos = apellidostxt.Text;
            dni = dnitxt.Text;
            fecha = fechaBox.Text;

            if (pesotxt.Text == "")
            {
                pesotxt.Text = "0";
                peso = 0;
            }
            else
            {
                peso = Convert.ToDouble(pesotxt.Text);
            }

            if (alturatxt.Text == "")
            {
                alturatxt.Text = "0";
                altura = 0;
            }
            else
            {
                altura = Convert.ToDouble(alturatxt.Text);
            }

            if (sexoHombre.IsChecked == true)
            {
                sexo = "Hombre";
            }
            else if (sexoMujer.IsChecked == true)
            {
                sexo = "Mujer";
            }
            else
            {
                sexo = "nosenocontesta";
            }

            if (nombre == "" || apellidos == "" || dni == "" || fecha == "" || peso == 0 || altura == 0) 
            {
                RellenaCampos rellenaCampos = new RellenaCampos();
                rellenaCampos.ShowDialog();
            }
            else
            {
                Usuario us = new Usuario(nombre, apellidos, dni, fecha, altura, peso, sexo);
                ListaUsuarios.AddUsuario(us);
                nombretxt.Clear();
                apellidostxt.Clear();
                dnitxt.Clear();
                pesotxt.Clear();
                alturatxt.Clear();
                fechaBox.ClearValue(DatePicker.SelectedDateProperty);
                RegistroExitoso registroExitoso = new RegistroExitoso();
                registroExitoso.ShowDialog();
            }

            
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }

            this.Close();
        }
    }
}
