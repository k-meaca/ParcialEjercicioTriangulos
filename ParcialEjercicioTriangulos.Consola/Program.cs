using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialEjercicioTriangulos.Entidades;

namespace ParcialEjercicioTriangulos.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangulo miTriangulo = new Triangulo();

                Console.WriteLine($"Triangulo de lados ladoA: {miTriangulo.LadoA}, ladoB: {miTriangulo.LadoB}, ladoC: {miTriangulo.LadoC}");
                Console.WriteLine(miTriangulo.ObtenerPerimetro());
                Console.WriteLine(miTriangulo.ObtenerSuperficie());
                Console.WriteLine(miTriangulo.ObtenerTipoTriangulo());

                Triangulo otroTriangulo = new Triangulo(5, 4, 3);

                Console.WriteLine($"Triangulo de lados ladoA: {otroTriangulo.LadoA}, ladoB: {otroTriangulo.LadoB}, ladoC: {otroTriangulo.LadoC}");
                Console.WriteLine(otroTriangulo.ObtenerTipoTriangulo());
                Console.WriteLine(otroTriangulo.ObtenerPerimetro());
                Console.WriteLine(otroTriangulo.ObtenerSuperficie());

                //Triangulo trianguloInvalido;

                //trianguloInvalido = new Triangulo(-5, 4, 3);

                //trianguloInvalido = new Triangulo(10, 1, 1);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
