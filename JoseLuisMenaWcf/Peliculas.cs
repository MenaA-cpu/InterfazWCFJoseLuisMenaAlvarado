using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoseLuisMenaWcf
{
    public class Peliculas
    {
        int Id_pelicula;
        string Nombre_pelicula;
        string Duracion_pelicula;
        string Genero_pelicula;

        public int ID_peliculas {
            set { Id_pelicula = value; }
            get { return Id_pelicula; }
        
        }

        public string nombre_pelicula {
            set { Nombre_pelicula = value; }
            get { return Nombre_pelicula; }
        }

        public string duracion_peliculas {
            set { Duracion_pelicula = value; }
            get { return Duracion_pelicula; }
        }

        public string genero_peliculas {
            set { Genero_pelicula = value; }
            get { return Genero_pelicula; }
        
        }
    }
}