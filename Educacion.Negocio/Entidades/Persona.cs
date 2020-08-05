using System;
using System.Collections.Generic;
using System.Text;

namespace Educacion.Negocio.Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        protected void Leer() 
        {
            //To DO
        }
    }
}
