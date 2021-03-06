﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Educacion.Negocio.Entidades
{
    public class Estudiante : Persona
    {
        public int EstudianteId { get; set; }

        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

        public void Estudiar() 
        {
            base.Leer();
        }
    }
}
