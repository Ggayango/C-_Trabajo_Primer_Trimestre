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
    public partial class MostrarUsuarios : Window
    {
        SoundPlayer My_JukeBox3 = new SoundPlayer(@"Pipboy_Select.wav");

        public MostrarUsuarios()
        {
            InitializeComponent();
            this.mostrarLista.ItemsSource = ListaUsuarios.usuarios;
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
