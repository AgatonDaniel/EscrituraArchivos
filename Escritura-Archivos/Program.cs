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
       
      

        static void Main(string[] args)
        {
            string Nom;
            string Edad;
            string Pelicula;

            Console.Write("Dame un nombre con apellidos: ");
            Nom = Convert.ToString(Console.ReadLine());
            Console.Write("Dame tu edad: ");
            Edad = Convert.ToString(Console.ReadLine());
            Console.Write("Dame tu Pelicula de favorita: ");
            Pelicula = Convert.ToString(Console.ReadLine());


            StreamWriter sw = new StreamWriter("Ejemplo.txt",true);
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            
            string[] Lines ={
                "Datos de la persona",
                 "El nombre es: " +  Nom,
                "la edada es: " + Edad,
               "Su pelicula favorita: " + Pelicula
             };

           
         
            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
