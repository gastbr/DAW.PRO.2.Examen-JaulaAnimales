using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen_programacion_2T
{
    internal class Jaula
    {
        int loros = 0;
        int monos = 0;
        List<Animal> animales;
        public Jaula()
        {
            animales = new List<Animal>();
        }
        public void CambiaColor()
        {
            for (int i = 0; i < animales.Count; i++)
            {
                if (animales[i] is Loro)
                {
                    ((Loro)animales[i]).AsignaColor();
                }
            }
            Console.WriteLine("Los loros han cambiado de color.");
        }
        public void Imprime()
        {
            int machos = 0;
            int hembras = 0;

            if (animales.Any())
            {
                Console.WriteLine("En la jaula hay: ");
                Console.WriteLine();
                for (int i = 0; i < animales.Count; i++)
                {
                    if (animales[i] is Loro)
                    {
                        ((Loro)animales[i]).Imprime();
                    }
                    else if (animales[i] is Mono)
                    {
                        ((Mono)animales[i]).Imprime();
                    }

                    if (animales[i].sexo == "Hembra")
                    {
                        hembras++;
                    }
                    else if (animales[i].sexo == "Macho")
                    {
                        machos++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Hay {this.monos} monos y {this.loros} loros.");
                Console.WriteLine($"Hay {hembras} hembras y {machos} machos.");
            }
            else
            {
                Console.WriteLine("La jaula está vacía. Añade animales con la tecla 2.");
            }
        }
        public void MeteAnimal()
        {
            Random rng = new Random();
            rng.Next(30); // descarta los 30 primeros random
            int random = rng.Next(2);
            if (random == 0) {
                animales.Add(new Loro());
                Console.WriteLine("Has metido un loro.");
                this.loros++;
            }
            else if (random == 1) {
                animales.Add(new Mono());
                Console.WriteLine("Has metido un mono.");
                this.monos++;
            }
        }
        public void Vacia()
        {
            animales.Clear();
            Console.WriteLine("Se ha vaciado la jaula.");
        }
    }
}
