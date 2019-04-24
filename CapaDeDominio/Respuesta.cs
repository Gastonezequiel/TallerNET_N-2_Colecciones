using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDominio
{
    class Respuesta
    {
        private int idRespuesta { get; set; }
        private String descripcion { get; set; }
        private bool esCorrecta;

        public bool getEsCorrecta()
        {
            return esCorrecta;
        }
    }
}
