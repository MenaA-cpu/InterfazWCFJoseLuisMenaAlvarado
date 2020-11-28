using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoseLuisMenaWcf
{
    public class Metodos
    {
        public String[] buscarPeli(int id) {
            string[] datos =new string[5];
            Peliculas peliculas = new Peliculas();
            if (id == 1)
            {
                peliculas.ID_peliculas = 189;
                datos[0] = peliculas.ID_peliculas.ToString();

                peliculas.nombre_pelicula = "tarzan la jungla de los canibales";
                datos[1] = peliculas.nombre_pelicula;

                peliculas.duracion_peliculas = "1 hora con de amadre tiempo";
                datos[2] = peliculas.duracion_peliculas;

                peliculas.genero_peliculas = "no se";
                datos[3] = peliculas.genero_peliculas;
                return datos;
            }
            else
            {
                if (id == 2)
                {
                    peliculas.ID_peliculas = 327;
                    datos[0] = peliculas.ID_peliculas.ToString();

                    peliculas.nombre_pelicula = "el secreto de la montaña";
                    datos[1] = peliculas.nombre_pelicula;

                    peliculas.duracion_peliculas = "2 minutos namas";
                    datos[2] = peliculas.duracion_peliculas;

                    peliculas.genero_peliculas = "pues calese xd";
                    datos[3] = peliculas.genero_peliculas;
                    return datos;
                }
                else
                {
                    if (id == 3)
                    {
                        peliculas.ID_peliculas = 123;
                        datos[0] = peliculas.ID_peliculas.ToString();

                        peliculas.nombre_pelicula = "tetanic";
                        datos[1] = peliculas.nombre_pelicula;

                        peliculas.duracion_peliculas = "9 horas de aburrimiento";
                        datos[2] = peliculas.duracion_peliculas;

                        peliculas.genero_peliculas = "ni la vean";
                        datos[3] = peliculas.genero_peliculas;
                        return datos;
                    }
                }

            }
            return datos;
        
        }
    }
}