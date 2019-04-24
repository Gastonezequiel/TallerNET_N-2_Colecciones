using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio
{
    class Pregunta
    {
        private int idPregunta { get; set; }
        //el ID refuerza la identidad del objeto y además sirve para cuando utilicemos la base de datos relacional.
        private String descripcion { get; set; }
        //Lo mejor es poner como privados los atributos del objeto
        //se puede acceder a ellos desde otras clases por medio de los getters y setters(Siempre son publicos)
        private int puntaje = 0;
        private List<Respuesta> listaRespuestas = new List<Respuesta>();

        public void setPuntaje(int puntaje)
        {
            this.puntaje = puntaje;
        }
        //this señala al objeto, en este caso Pregunta (ejemplo: this.idPregunta)
        public int getPuntaje()
        {
            return this.puntaje;
        }

        public void agregarRespuesta(Respuesta respuesta)
        {
            this.listaRespuestas.Add(respuesta);
        }

        public List<Respuesta> getRespuestas()
        {
            return this.listaRespuestas;
        }

        /*public Respuesta getRespuestaCorrecta()
        {
            Respuesta respuestaCorrecta = new Respuesta();
            for (int i = 0; i < listaRespuestas.Count; i++)
            {
                Respuesta r;
                r = listaRespuestas[i];
                if (r.getEsCorrecta())
                {
                    respuestaCorrecta = r;
                }
            }
            return respuestaCorrecta;
        }*/

        public Respuesta getRespuestaCorrecta()
        {
            return listaRespuestas.Find(respuesta => respuesta.getEsCorrecta());
        }
    }
}
