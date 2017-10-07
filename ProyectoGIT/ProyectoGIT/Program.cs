using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProyectoGIT
{
    class Program
    {
        enum Colores { blanco, negro, rojo, azul, gris, amarillo, verde };
        enum TipoHeladera { Congelador, Frigorifico };
        enum AlimentacionCocina { Electrica, Gas };
        static void Main(string[] args)
        {
            Program aplicacion = new Program();
            aplicacion.Inicio();
        }
        public void Inicio()
        {
            ArrayList electrodomesticos = new ArrayList();
            char[] consumoEnergetico = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            for (int i = 1; i <= 3; i++)
            {
                Random random = new Random();
                int x = random.Next(1, 4);
                switch (x)
                {
                    case 1:
                        cargarLavarropa(electrodomesticos, consumoEnergetico);
                        break;
                    case 2:
                        cargarHeladera(electrodomesticos, consumoEnergetico);
                        break;
                    case 3:
                        cargarCocina(electrodomesticos, consumoEnergetico);
                        break;
                }
            }
            mostrarArray(electrodomesticos);
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
        public void cargarHeladera(ArrayList e, char[] consumoEnergetico)
        {
            Random random = new Random();
            double precio = random.NextDouble() + random.Next(0, 100);
            double peso = random.NextDouble() + random.Next(5, 100);
            string color = Enum.GetName(typeof(Colores), random.Next(7));
            string tipo = Enum.GetName(typeof(TipoHeladera), random.Next(2));
            e.Add(new Heladera(Math.Round(precio, 2), color, consumoEnergetico[random.Next(1, 9)], Math.Round(peso, 2), tipo, random.Next(100)));
        }
        public void cargarLavarropa(ArrayList e, char[] consumoEnergetico)
        {
            Random random = new Random();
            double precio = random.NextDouble() + random.Next(0, 100);
            string color = Enum.GetName(typeof(Colores), random.Next(7));
            double peso = random.NextDouble() + random.Next(5, 100);
            e.Add(new Lavarropa(Math.Round(precio, 2), color, consumoEnergetico[random.Next(1, 9)], Math.Round(peso, 2), random.Next(100)));
        }
        public void cargarCocina(ArrayList e, char[] consumoEnergetico)
        {
            Random random = new Random();
            double precio = random.NextDouble() + random.Next(0, 100);
            string color = Enum.GetName(typeof(Colores), random.Next(7));
            double peso = random.NextDouble() + random.Next(5, 100);
            string alimentacion = Enum.GetName(typeof(AlimentacionCocina), random.Next(2));
            e.Add(new Cocina(Math.Round(precio, 2), color, consumoEnergetico[random.Next(1, 9)], Math.Round(peso, 2), random.Next(80, 95), random.Next(50, 120), random.Next(60, 70), alimentacion));
        }
        public void mostrarArray(ArrayList vector)
        {
            foreach (Electrodomestico e in vector)
            {
                e.mostrar();
            }
        }
    }
}
