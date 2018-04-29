using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;  

namespace MvcMovie.Models
{
    public class Tache
    {
        public int ID { get; set; } // Clé primaire de la tache Tache

        [Display(Name ="Date Début")]
        [DataType(DataType.DateTime)]
        public DateTime DateDebut { get; set; }

        [Display(Name = "Date Fin")]
        [DataType(DataType.DateTime)]
        public DateTime DateFin { get; set; }

        [Display(Name = "Nom de la tâche")]
        public string NomTache { get; set; }

        [Display(Name = "Description de la tâche")]
        public string Description { get; set; }
    }
}
