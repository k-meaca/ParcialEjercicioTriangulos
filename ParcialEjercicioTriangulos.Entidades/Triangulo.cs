using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjercicioTriangulos.Entidades
{
    public class Triangulo
    {
        //ATRIBUTOS
        private int ladoA, ladoB, ladoC;

        //PROPIEDADES
        public int LadoA { get => ladoA; }

        public int LadoB { get => ladoB; }

        public int LadoC { get => ladoC; }

        //CONSTRUCTORES

        /// <summary>
        /// Construye un triangulo
        /// </summary>
        /// <param name="ladoA">LadoA = Hipotenusa</param>
        /// <param name="ladoB">LadoB = Cateto</param>
        /// <param name="ladoC">LadoC = Cateto</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            if (!EsTriangulo(ladoA, ladoB, ladoC))
            {
                throw new ArgumentException("Los lados ingresados no forman un triangulo");
            }

            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public Triangulo() : this(1, 1, 1) { }


        //METODOS
        private bool EsTriangulo(int ladoA, int ladoB, int ladoC)
        {
            bool valido = false;

            if (ladoA > 0 && ladoB < 0 && ladoC < 0)
              
                valido = true;
            else if ((ladoA + ladoA > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            
                valido = true;
            

            return valido;
        }

        private bool EsRectangulo()
        {
            return Math.Pow(ladoA, 2) == (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2));
        }


        private bool EsObtusangulo()
        {
            return Math.Pow(ladoA, 2) > (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2));
        }

        private double Semiperimetro()
        {
            return (ladoA + ladoB + ladoC) / 2.0f;
        }

        //PUBLICOS

        public string ObtenerTipoTriangulo()
        {
            string triangulo;

            if (EsRectangulo())
                triangulo = "Rectangulo";
            else if (EsObtusangulo())
                triangulo = "Obtusangulo";
            else
                triangulo = "Acutangulo";

            return triangulo;
        }

        public int ObtenerPerimetro()
        {
            return ladoA + ladoB + ladoC;
        }

        public double ObtenerSuperficie()
        {
            return Math.Sqrt(Semiperimetro() * (Semiperimetro() - ladoA) * (Semiperimetro() - ladoB) * (Semiperimetro() - ladoC));
        }
    }
}
