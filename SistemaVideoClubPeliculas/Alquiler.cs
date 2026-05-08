using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVideoClubPeliculas
{
    //internal class Alquiler
    public class Alquiler
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }

        public Alquiler(int id, Usuario usuario , List<Pelicula> peliculas, DateTime fecha, double precio)

        {
            Id = id;
            Usuario = usuario;
            Peliculas = peliculas;
            Fecha = fecha;
            Precio = precio;

        }


    }
}
