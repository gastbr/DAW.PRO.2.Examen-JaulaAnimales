using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_programacion_2T
{
    internal abstract class Animal
    {
        public string sexo = "";

        public void AsignaSexo()
        {
            Random rng = new Random();
            if (rng.Next(2) == 0)
            {
                sexo = "Hembra";
            }
            else
            {
                sexo = "Macho";
            }
        }
    }
}
