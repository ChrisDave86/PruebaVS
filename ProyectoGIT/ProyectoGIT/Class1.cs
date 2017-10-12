using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGIT
{
    //clase de electronico de Cristian
    class Electrodomestico
    {
        public enum Colores //es un tipo de vector que almacena solo esos datos
        {
            BLANCO,
            NEGRO,
            AZUL,
            GRIS
        };

        public enum ConsumoEnergetico
        {
            A, B, C, D, E, F
        };


        private float precioBase;



        private Colores colorElectrodomestico;//atributo del tipo del enum Colores



        private ConsumoEnergetico consumoEnergetico;//atributo del tipo enum ConsumoEnergetico

        private float peso;
        private float precioFinal;



        public Electrodomestico()//constructor por defecto
        {

            precioBase = 0f;
            colorElectrodomestico = Colores.BLANCO;
            consumoEnergetico = ConsumoEnergetico.A;
            peso = 5f;

        }

        public Electrodomestico(float _precioBase, Colores _colorElectrodomestico, ConsumoEnergetico _consumoEnergetico, float _peso)//constructor con los atributos
        {
            precioBase = _precioBase;
            colorElectrodomestico = _colorElectrodomestico;
            consumoEnergetico = _consumoEnergetico;
            peso = _peso;
        }

        public virtual void Mostrar()//funcion mostrar que tiene que ser llamada de cada clase de electrodomestico por eso usa la palabra virtual
        {
            Console.WriteLine("Color: {0}", colorElectrodomestico);
            Console.WriteLine("Consumo energetico: {0}", consumoEnergetico);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Precio Base: {0}", precioBase);


        }


        public float PrecioBase
        {
            get
            {
                return precioBase;
            }
            set
            {
                if (value > 0)
                {
                    precioBase = value;
                }


            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }

        public ConsumoEnergetico ConsumoEnerg
        {
            get
            {
                return consumoEnergetico;
            }
            set
            {

                if ((value != ConsumoEnergetico.A) && (value != ConsumoEnergetico.B) && (value != ConsumoEnergetico.C) && (value != ConsumoEnergetico.D) && (value != ConsumoEnergetico.E) && (value != ConsumoEnergetico.F))
                {
                    value = ConsumoEnergetico.F;
                }

                consumoEnergetico = value;
            }
        }

        public Colores ColorElectrodomestico
        {
            get
            {
                return colorElectrodomestico;
            }
            set
            {

                if ((value != Colores.BLANCO) && (value != Colores.AZUL) && (value != Colores.GRIS) && (value != Colores.NEGRO))
                {
                    value = Colores.BLANCO;
                }

                colorElectrodomestico = value;
            }
        }

        public float PrecioFinal
        {
            get
            {
                precioFinal = CalculoPrecioFinal();
                return precioFinal;
            }
        }//fin propiedad PrecioFinal

        //Metodo que calcula el precio final
        public virtual float CalculoPrecioFinal()
        {
            float pf, valorConsumo = 0, valorPeso = 0;


            switch (consumoEnergetico)
            {
                case ConsumoEnergetico.A: valorConsumo = 100; break;
                case ConsumoEnergetico.B: valorConsumo = 80; break;
                case ConsumoEnergetico.C: valorConsumo = 60; break;
                case ConsumoEnergetico.D: valorConsumo = 50; break;
                case ConsumoEnergetico.E: valorConsumo = 30; break;
                case ConsumoEnergetico.F: valorConsumo = 10; break;
                default: Console.WriteLine("Error: El valor del consumo energetico no es correcto."); break;
            }

            if ((peso > 0) && (peso < 19))
            {
                valorPeso = 10;
            }
            else if ((peso > 20) && (peso < 49))
            {
                valorPeso = 50;
            }
            else if ((peso > 50) && (peso < 79))
            {
                valorPeso = 80;
            }
            else if (peso > 80)
            {
                valorPeso = 100;
            }

            pf = precioBase + valorPeso + valorConsumo;
            return pf;
        }
    }
}
