using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGIT
{
    class Cocina : Electrodomestico
    {
        int alto;
        int ancho;
        int profundidad;
        string alimentacion;

        public Cocina()
        {
            this.Alto = 85;
            this.Ancho = 65;
            this.Profundidad = 65;
            this.Alimentacion = "Gas";
        }
        public Cocina(double precioBase, String color, char consumo, double peso, int alto, int ancho, int profundidad, string alimentacion)
            : base(precioBase, color, consumo, peso)
        {
            this.Alto = alto;
            this.Ancho = ancho;
            this.Profundidad = profundidad;
            this.Alimentacion = alimentacion;
        }

        public int Alto { get => alto; set => alto = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public int Profundidad { get => profundidad; set => profundidad = value; }
        public string Alimentacion { get => alimentacion; set => alimentacion = value; }

        public override double PrecioFinal()
        {
            double precioFCocina = base.PrecioFinal();
            if ((this.ancho >= 60) & (this.ancho < 80))
            { precioFCocina = precioFCocina + Math.Round((precioFCocina * 100 / 15), 2); ; }
            //la funcion math redondea el numero decimal a 2 decimales  
            else
            {
                if ((this.ancho >= 80) & (this.ancho < 100))
                { precioFCocina = precioFCocina + Math.Round((precioFCocina * 100 / 20), 2); }
                else
                {
                    precioFCocina = precioFCocina + Math.Round((precioFCocina * 100 / 30), 2);
                }
            }
            return precioFCocina;
        }
        public override void mostrar()
        {
            Console.Write("COCINA ");
            base.mostrar();
            Console.Write("alto: {0}, ancho: {1}, profundidad: {2}, alientacion: {3}, PRECIO FINAL: {4}$\n", this.alto, this.ancho, this.profundidad, this.alimentacion, PrecioFinal());
        }
    }
}

