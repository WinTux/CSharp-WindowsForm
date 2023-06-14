using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_WindowsForm
{
    public partial class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        private bool egresado;
        public bool Egresado
        {
            get
            {
                return egresado;
            }
            set
            {
                egresado = value;
            }
        }
    }
}

namespace genericas
{
    public class ListaGenerica<T>
    {
        private T[] elementos;
        private int tamanyo, actual;
        public ListaGenerica(int size)
        {
            elementos = new T[tamanyo = size];
            actual = 0;
        }
        public void add(T elem)
        {
            if (actual < tamanyo)
                elementos[actual++] = elem;
        }
        public T get(int posicion)
        {
            return elementos[posicion];
        }
    }
}
