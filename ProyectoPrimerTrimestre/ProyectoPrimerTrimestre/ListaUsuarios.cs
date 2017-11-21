using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestre
{
    public static class ListaUsuarios
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        public static void AddUsuario(Usuario us)
        {
            bool repetido = false;

            foreach (Usuario usuario in ListaUsuarios.usuarios)
            {
                if (usuario.Dni.Equals(us.Dni))
                {
                    repetido = true;
                }

            }

            if (repetido)
            {
                RepetidoDNI repetidoDNI = new RepetidoDNI();
                repetidoDNI.ShowDialog();
            }
            else
            {                
                usuarios.Add(us);
            }
            
        }

    }

}
