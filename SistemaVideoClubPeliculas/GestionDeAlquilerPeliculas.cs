using System;
using System.Collections.Generic;

namespace SistemaVideoClubPeliculas
{
    public class GestionDeAlquilerPeliculas
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public List<Alquiler> Alquileres { get; set; }

        public GestionDeAlquilerPeliculas()
        {
            Usuarios = new List<Usuario>();
            Peliculas = new List<Pelicula>();
            Alquileres = new List<Alquiler>();
        }

        public void RegistrarUsuarios(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public void RegistrarPeliculas(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
        }
        public void Alquilar(int idAlquiler, Usuario usuario, List<int> idsPeliculas)
        {
            var alquiler = new Alquiler(idAlquiler, usuario, new List<Pelicula>(), DateTime.Now, 0);

            foreach (var id in idsPeliculas)
            {
                var peli = Peliculas.Find(p => p.Id == id);

                if (peli != null && peli.Disponible)
                {
                    peli.Disponible = false;
                    alquiler.Peliculas.Add(peli);
                    alquiler.Precio += 100;
                }
            }

            Alquileres.Add(alquiler);

        }
        public void Devolver(int idAlquiler)
        {
            var alquiler = Alquileres.Find(a => a.Id == idAlquiler);

            if (alquiler != null)
            {
                foreach (var p in alquiler.Peliculas)
                {
                    p.Disponible = true;
                }
            }
        }

    }

}