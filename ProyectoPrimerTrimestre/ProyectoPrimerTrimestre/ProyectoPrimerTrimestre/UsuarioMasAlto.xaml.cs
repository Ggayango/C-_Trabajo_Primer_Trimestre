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
    /// Lógica de interacción para UsuarioMasAlto.xaml
    /// </summary>
    public partial class UsuarioMasAlto : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public UsuarioMasAlto()
        {
            InitializeComponent();

            double masAlto = 0;

            for (int i = 0; i < ListaUsuarios.usuarios.Count; i++)
            {
                if (masAlto < ListaUsuarios.usuarios[i].Altura)
                {
                    masAlto = ListaUsuarios.usuarios[i].Altura;
                }
            }

            foreach (Usuario usuario in ListaUsuarios.usuarios)
            {
                if (masAlto.Equals(usuario.Altura))
                {
                    masAltoMostrar.Text = usuario.ToString();
                }
            }
        }

        private void salir_Click(object sender, RoutedEventArgs e)
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
