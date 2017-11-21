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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoPrimerTrimestre
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
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

            Registro_de_Usuario registro_De_Usuario = new Registro_de_Usuario();
            registro_De_Usuario.ShowDialog();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
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

            MostrarUsuarios mostrarUsuarios = new MostrarUsuarios();
            mostrarUsuarios.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
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

            MostrarUsuariosDNI mostrarUsuariosdni = new MostrarUsuariosDNI();
            mostrarUsuariosdni.ShowDialog();

            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
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

            UsuarioMasAlto usuarioMasAlto = new UsuarioMasAlto();
            usuarioMasAlto.ShowDialog();

            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
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

            UsuarioMenorPeso usuarioMenorPeso = new UsuarioMenorPeso();
            usuarioMenorPeso.ShowDialog();

            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
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

            try
            {
                My_JukeBox3.Play();
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }
    }
}
