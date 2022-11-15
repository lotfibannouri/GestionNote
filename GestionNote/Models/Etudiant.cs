using System.ComponentModel.DataAnnotations;

namespace GestionNote.Models
{
    public class Etudiant
    {
        [Key]
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom  { get; set; }
        public ICollection<Notes> notes { get; set; }

    }
}
