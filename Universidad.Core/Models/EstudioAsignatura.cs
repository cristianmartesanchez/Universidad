﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Models
{
    public class EstudioAsignatura
    {
        [Key]
        public int Id { get; set; }       
        public int CarreraId { get; set; }
        public int AsignaturaId { get; set; }
        public Carreras Estudio { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
