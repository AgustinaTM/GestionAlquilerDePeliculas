using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaVideoClubPeliculas
{
    public class Promocion
    {
        public string Descuentos { get; set; }
        public bool Activo { get; set; }

        public Promocion(string descuentos, bool activo)

        {
            Descuentos = descuentos;
            Activo = activo;

        }

    }

}
