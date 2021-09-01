using System;

namespace SRP 
{
    public class Ubicacion
    {
        public string sector { get; private set; }
        public string estante { get; private set; }
        public Libro libro { get; private set; }


        public Ubicacion(Libro libro, String sector, String estante)
        {
            this.libro = libro;
            this.sector = sector;
            this.estante = estante;
        }
    }
}