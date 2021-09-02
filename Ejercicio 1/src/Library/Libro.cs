using System;

namespace SRP
{
    public class Libro
    {
        public string Titulo { get ; private set; }
        public string Autor { get ; private set; }
        public string Codigo { get ; private set; }
        public Ubicacion UbicacionLibro { get; private set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
            
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.UbicacionLibro = new Ubicacion(this, sector, estante);
        }
    }
}
