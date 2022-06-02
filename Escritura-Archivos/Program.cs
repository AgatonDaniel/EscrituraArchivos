using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_Archivos
{
    class Program
    {
       class  Datos
       {
            //Campos
            public string Nom;
            public   int Edad;
            public string Pelicula;
            public string Musica;


            public Datos(string Nom, int Edad, string Pelicula, string Musica, string Vj)//Constructor
            {
                this.Nom = Nom;
                this.Edad = Edad;
                this.Pelicula = Pelicula;
                this.Musica = Musica;

            }
            
          
            
        }
    
        static void Main(string[] args)
        {
            //Variables
            string Nom;
            int Edad;
            string Pelicula;
            string Musica;
            string Vj;
            //Pedir datos
            Console.Write("Dame un nombre con apellidos: ");
            Nom = Convert.ToString(Console.ReadLine());
            Console.Write("Dame tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cual es tu Pelicula de favorita: ");
            Pelicula = Convert.ToString(Console.ReadLine());
            Console.Write("cual es tu Musica de favorita: ");
            Musica = Convert.ToString(Console.ReadLine());
            Console.Write("cual es tu Videojuego de favorita: ");
             Vj = Convert.ToString(Console.ReadLine());

            //Creacion de objetos
            StreamWriter sw = new StreamWriter("Ejemplo.txt",true);
            Datos D = new Datos(Nom, Edad, Pelicula, Musica, vj);
       
            //Imprimir datos
            sw.WriteLine("Datos de la persona");
            sw.WriteLine("El nombre es: " + D.Nom);
            sw.WriteLine("la edada es: " + D.Edad);
            sw.WriteLine("Su pelicula favorita: " + D.Pelicula);
            sw.WriteLine("Su Musica favorita: " + D.Musica);

            sw.Close();

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
