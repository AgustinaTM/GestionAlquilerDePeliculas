using System;
using System.Collections.Generic;

namespace SistemaVideoClubPeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new GestionDeAlquilerPeliculas();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== BIENVENIDOS AL SISTEMA DE GESTIÓN DE ALQUILER DE PELÍCULAS ===");
                Console.WriteLine("1. Registrar usuario");
                Console.WriteLine("2. Registrar película");
                Console.WriteLine("3. Alquilar");
                Console.WriteLine("4. Devolver");
                Console.WriteLine("5. Salir");

                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Id: ");
                        int idU = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine() ?? "";

                        Console.Write("Contraseña: ");
                        string pass = Console.ReadLine() ?? "";

                        sistema.RegistrarUsuarios(new Usuario(idU, nombre, pass));
                        Console.WriteLine("Usuario registrado!");
                        break;

                    case 2:
                        Console.Write("Id: ");
                        int idP = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Título: ");
                        string titulo = Console.ReadLine() ?? "";

                        Console.Write("Duración: ");
                        int duracion = int.Parse(Console.ReadLine() ?? "0");

                        sistema.RegistrarPeliculas(new Pelicula(idP, titulo, duracion));
                        Console.WriteLine("Película registrada!");
                        break;

                    case 3:
                        Console.Write("Id alquiler: ");
                        int idA = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Id usuario: ");
                        int idUsuario = int.Parse(Console.ReadLine() ?? "0");

                        var usuario = sistema.Usuarios.Find(u => u.Id == idUsuario);

                        if (usuario == null)
                        {
                            Console.WriteLine("Usuario no encontrado.");
                            break;
                        }

                        Console.Write("Id película: ");
                        int idPeli = int.Parse(Console.ReadLine() ?? "0");

                        sistema.Alquilar(idA, usuario, new List<int> { idPeli });

                        Console.WriteLine("Alquiler registrado correctamente ✅");
                        break;

                    case 4:
                        Console.Write("Id alquiler: ");
                        int idDev = int.Parse(Console.ReadLine() ?? "0");

                        sistema.Devolver(idDev);
                        Console.WriteLine("Devolución realizada correctamente ✅");
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}