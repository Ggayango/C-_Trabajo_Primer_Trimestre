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
    /// Lógica de interacción para MostrarUsuarios.xaml
    /// </summary>
    public partial class MostrarUsuariosDNI : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public MostrarUsuariosDNI()
        {
            InitializeComponent();
        }

        private void buscarBTN_Click(object sender, RoutedEventArgs e)
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

            UsuarioNoEncontrado usuarioNo = new UsuarioNoEncontrado();
            string dni;

            dni = buscarDNI.Text;

            foreach (Usuario usuario in ListaUsuarios.usuarios)
            {
                if (dni.Equals(usuario.Dni))
                {
                    mostrarDNI.Text = usuario.ToString();
                }
            }

            if (mostrarDNI.Text == "" || dni == "")
            {
                usuarioNo.ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
