using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVideoClubPeliculas
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public bool Disponible { get; set; }

        public Pelicula(int id, string titulo, int duracion)
        {
            Id = id;
            Titulo = titulo;
            Duracion = duracion;
            Disponible = true;
        }
    }
}
       

      

