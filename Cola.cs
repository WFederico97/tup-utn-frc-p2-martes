using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tup_utn_frc_p2_martes
{
    public class Cola
    {
        private List<object> Elementos;

        public Cola()
        {
            Elementos = new List<object>();
        }

        public bool EstaVacia()
        {
            return Elementos.Count == 0;
        }

        public object Extraer()
        {
            object elementoEliminado = Elementos[0];
            if (EstaVacia())
            {
                Console.WriteLine("No hay elementos en la cola");
            }
            else
            {
                Elementos.RemoveAt(0);
                Console.WriteLine($"Elemento eliminado : {elementoEliminado}");
            }
            return elementoEliminado;
        }

        public bool Añadir(object objeto)
        {
            bool flag = false;

            Elementos.Add(objeto);
            if (Elementos.Contains(objeto))
            {
                Console.WriteLine($"Su objeto {objeto}, fue añadido con exito");
                flag = true;
            }
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
