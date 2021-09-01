using System;

namespace SRP
{
    public class Libro
    {
        public string Titulo { get ; private set; }
        public string Autor { get ; private set; }
        public string Codigo { get ; private set; }
        public Ubicacion Ubicacion { get; private set; }

        public Libro(String titulo, String autor, String codigo, String sector, String estante)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
            this.ubicacion = new Ubicacion(sector, estante);
        }
    }

    public class Biblioteca
    {
        private string nombreBiblioteca { get; }
        private List<Libro> listaLibros = new List<Libro>();

        public Biblioteca(string nombreBiblioteca)
        {
            this.nombreBiblioteca = nombreBiblioteca;
        }

        public AlmacenarLibro(Libro libro)       
        {
            
        }

    }

    public class Ubicacion
    {
        private string sector { get; set; }
        private string estante { get; set; }

        public Ubicacion(string sector, string estante)
        {
            this.sector = sector;
            this.estante = estante;
        }

    }
}
