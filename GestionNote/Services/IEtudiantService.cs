using GestionNote.Models;

namespace GestionNote.Services
{
    public interface IEtudiantService
    {

        List<Etudiant> GetEtudiants();
        bool AddEtudiant (Etudiant etudiant);

        bool RemoveEtudiant (int id);

        bool EditEtudiant(Etudiant etudiant);

        Etudiant GetEtudiantById (int id);

    }
}
