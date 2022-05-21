using System;
using System.Collections.Generic;

namespace EjemploSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando clase para conexión a DB (se instancia una sola ven) accediendo por notación y no por new
            SingletonDBConexion c1 = SingletonDBConexion.Conexion();
            SingletonDBConexion c2 = SingletonDBConexion.Conexion();

            // Validamos que las instancia sea la misma
            if (c1 == c2)
            {
                Console.WriteLine("Si es la misma instancia, conexión exitosa.");
            }

            Console.ReadKey();
        }

        public class SingletonDBConexion
        {
            static SingletonDBConexion conexion;
            protected SingletonDBConexion()
            {
            }
            public static SingletonDBConexion Conexion()
            {
                if (conexion == null)
                {
                    conexion = new SingletonDBConexion();
                }
                return conexion;
            }
        }

    }
}
