using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tup_utn_frc_p2_martes
{
    public class Pila : IColleccion
    {
        public object[] Elementos;
        private int Contador;

        public Pila(int tamano)
        {
            Elementos = new object[tamano];
        }

        public bool EstaVacia()
        {
            return Elementos.Length == 0;
        }

        public object Extraer()
        {
            object elementoEliminado = Elementos.Last();
            if (EstaVacia())
            {
                Console.WriteLine("No hay elementos en la pila");
            }
            else
            {
                Console.WriteLine($"Elemento eliminado : {elementoEliminado}");
            }
                return elementoEliminado;
        }

        public bool Añadir(object objeto)
        {
            bool flag = false;

            Elementos[Contador] = objeto;
            if (Elementos.Contains(objeto))
            {
                Console.WriteLine($"Su objeto {objeto}, fue añadido con exito");
                flag = true;
            }
            Contador++;
            return flag;
        }

        public object Primero()
        {
            object firstElement = Elementos.First();

            Console.WriteLine($"El primer elemento es : {firstElement}");
            return firstElement;
        }
    }
}
