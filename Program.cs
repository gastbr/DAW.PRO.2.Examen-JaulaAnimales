using Examen_programacion_2T;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKey tecla;
        Jaula jaula = new Jaula();
        Console.WriteLine("1. Listado de Animales\r\n2. Meter Animal\r\n3. Vaciar la jaula\r\n4. Cambiar color\r\n5. Salir\r\n");
        while (true)
        {
            tecla = Console.ReadKey(true).Key;
            Console.Clear();
            Console.WriteLine("1. Listado de Animales\r\n2. Meter Animal\r\n3. Vaciar la jaula\r\n4. Cambiar color\r\n5. Salir\r\n");
            switch (tecla)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    jaula.Imprime();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    jaula.MeteAnimal();
                    Console.WriteLine();
                    jaula.Imprime();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    jaula.Vacia();
                    Console.WriteLine();
                    jaula.Imprime();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    jaula.CambiaColor();
                    Console.WriteLine();
                    jaula.Imprime();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}