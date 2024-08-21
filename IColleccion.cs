using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tup_utn_frc_p2_martes
{
    public interface IColleccion
    {
        public bool EstaVacia();
        public object Extraer();
        public object Primero();
        public bool Añadir(object objeto);
    }
}
