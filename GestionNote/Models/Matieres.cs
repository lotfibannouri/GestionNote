using System.ComponentModel.DataAnnotations;

namespace GestionNote.Models
{
    public class Matieres
    {
        [Key]
        public int  ID { get; set; }
        public int Coef { get; set; }
        public string Description { get; set; }
        public ICollection<Notes> notes { get; set; }

    }
}