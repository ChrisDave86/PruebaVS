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

        public Cocina()//constructor por defecto
        {
            this.Alto = 85;
            this.Ancho = 65;
            this.Profundidad = 65;
            this.Alimentacion = "Gas";
        }
        public Cocina(double precioBase, String color, char consumo, double peso, int alto, int ancho, int profundidad, string alimentacion)
            : base(precioBase, color, consumo, peso)//se asigna estas variables para que vayan a la clase Electrodomestico con la palabra base y entre ()
            /*constructor con los atributos.. este es el metodo que se lo llama desde el MAIN y ponemos los atributos de 
             */
        {
            this.Alto = alto;
            this.Ancho = ancho;
            this.Profundidad = profundidad;
            this.Alimentacion = alimentacion;
        }

        public int Alto { get => alto; set => alto = value; }//estos son metodos de get y set que devuelven el valor que se encuentra en en dicha cocina
        public int Ancho { get => ancho; set => ancho = value; }//pero no seran de utilidad en este programa.. solo lo ponemos porque lo dice el problema
        public int Profundidad { get => profundidad; set => profundidad = value; }//estan con mayuscula al principio solo para difenciarlos de los atributos que estan en minuscula 
        public string Alimentacion { get => alimentacion; set => alimentacion = value; }

        public override double PrecioFinal()
            /*(3) aqui es llamada del metodo de mostrar
             se crea una variable precioFCocina y se le asigna lo que estaba como precio final en la clase electrodomestico(4)
             y se hace las opercacion que qhace qye se le agregue mas precio a la cocina
             finalmente devuelve un precio que seria el precio final de la cocina(5)*/
        {
            double precioFCocina = base.PrecioFinal();//(4)llama al metodo de la clase electrodomestico 
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
            return precioFCocina;//(5)
        }
        public override void mostrar()
         /*este procedimiento muestra los atributos de la cocina. Tiene que tener la palabra override para que sepa que usa
          * un procedimiento de la clase Base que es la de electrodomestico. Primero el nombre COCINA para indicar que es una cocina
          * despues llama a al metodo de la clase electrodomestico tienen que tener el mismo nombre  y la palabra base.(2)
          para que primero muestre el precioBase el consumo el peso
          luego vuelve a este procedimiento y terminar de mostrar los atributos que le falta a la cocina que son el alto ancho profundidad alimentacion y el precio final llamando
          a la funcion de arriba(3)*/   
        {
            Console.Write("COCINA ");
            base.mostrar();//(2)
            Console.Write("alto: {0}, ancho: {1}, profundidad: {2}, alientacion: {3}, PRECIO FINAL: {4}$\n", this.alto, this.ancho, this.profundidad, this.alimentacion, PrecioFinal());
                                                                                                         //ponemos this para indicar que son las atributos de la cocina
        }
    }
}

