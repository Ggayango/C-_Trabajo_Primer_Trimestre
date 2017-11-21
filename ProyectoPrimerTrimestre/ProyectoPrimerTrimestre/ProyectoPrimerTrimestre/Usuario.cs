using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestre
{
    public class Usuario
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private string fecha;
        private double altura;
        private double peso;
        private string sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellidos, string dni, string fecha, double altura, double peso, string sexo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fecha = fecha;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
        }

        public int Compare(Usuario x, Usuario y)
        {
            if (x.Altura.CompareTo(y.Altura) != 0)
            {
                return x.Altura.CompareTo(y.Altura);
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "=================================="+ "\n" +
                   "Nombre: " + Nombre + "\n" +
                   "Apellidos: " + Apellidos + "\n" +
                   "DNI: " + Dni + "\n" +
                   "Peso: " + Peso + "\n" +
                   "Altura: " + Altura /100 + "\n" +
                   "Edad: " + Fecha + "\n" +
                   "Sexo: " + Sexo + "\n" +
                   "==================================";
        }

        public override int GetHashCode()
        {
            var hashCode = -2102852476;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fecha);
            hashCode = hashCode * -1521134295 + Altura.GetHashCode();
            hashCode = hashCode * -1521134295 + Peso.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sexo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fecha);
            hashCode = hashCode * -1521134295 + Altura.GetHashCode();
            hashCode = hashCode * -1521134295 + Peso.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sexo);
            return hashCode;
        }
    }
}
