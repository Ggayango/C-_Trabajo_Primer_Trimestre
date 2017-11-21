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
    /// Lógica de interacción para UsuarioMenorPeso.xaml
    /// </summary>
    public partial class UsuarioMenorPeso : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public UsuarioMenorPeso()
        {
            InitializeComponent();

            double menorPeso = 0;

            for (int i = 0; i < ListaUsuarios.usuarios.Count; i++)
            {
                menorPeso = ListaUsuarios.usuarios[i].Peso;

                if (menorPeso > ListaUsuarios.usuarios[i].Peso)
                {
                    menorPeso = ListaUsuarios.usuarios[i].Peso;
                }
            }

            foreach (Usuario usuario in ListaUsuarios.usuarios)
            {
                if (menorPeso.Equals(usuario.Peso))
                {
                    menorPesoMostrar.Text = usuario.ToString();
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
