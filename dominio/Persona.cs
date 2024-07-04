using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Nacionalidad { get; set; }

        public string UrlFoto { get; set; }

        public Estilo EstiloMusical { get; set; }

    }
}
