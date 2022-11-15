using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionNote.Models
{
    public class Notes
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Etudiant")] 
        public int IDEtudiant { get; set; }
        public Etudiant Etudiant { get; set; }
        [ForeignKey("Matieres")]
        public int IDMatieres { get; set; }
        public Matieres Matieres { get; set; }
        public double note {get; set; }


    }
}