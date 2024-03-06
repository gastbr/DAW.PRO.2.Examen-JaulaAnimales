using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_programacion_2T
{
    internal class Loro : Animal
    {
        Colores color;
        public Loro()
        {
            AsignaColor();
            AsignaSexo();
        }

        public void Imprime()
        {
            Console.WriteLine($"Un loro {sexo} {color}.");
        }
        public void AsignaColor()
        {
            Random rng = new Random();
            rng.Next(30); // se descartan los primeros 30 números
            int random = rng.Next(8);
            switch (random)
            {
                case 0:
                    color = Colores.rojo;
                    break;
                case 1:
                    color = Colores.verde;
                    break;
                case 2:
                    color = Colores.azul;
                    break;
                case 3:
                    color = Colores.morado;
                    break;
                case 4:
                    color = Colores.rosa;
                    break;
                case 5:
                    color = Colores.amarillo;
                    break;
                case 6:
                    color = Colores.naranja;
                    break;
                case 7:
                    color = Colores.marron;
                    break;
            }
        }

    }
}
