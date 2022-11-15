using GestionNote.Models;
using GestionNote.Repositories;

namespace GestionNote.Services
{
    public class EtudiantService : IEtudiantService
    {
        private readonly EtudiantRepository _etudiantRepository;
        public EtudiantService(EtudiantRepository etudiantRepository)
        {
            _etudiantRepository = etudiantRepository;
        }

        public bool AddEtudiant(Etudiant etudiant)
        {
            try
            {
                _etudiantRepository.AddEtudiant(etudiant);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditEtudiant(Etudiant etudiant)
        {
            try
            {
                _etudiantRepository.EditEtudiant(etudiant);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Etudiant GetEtudiantById(int id)
        {
            var rst = _etudiantRepository.GetEtudiantByID(id);
            if (rst == null)
            {
                rst = new Etudiant();
                return rst;
            }
            else { return rst; }

        }

        public List<Etudiant> GetEtudiants()
        {
            var rst = _etudiantRepository.GetEtudiants();
            if (rst == null)
            {
                rst=new List<Etudiant>();
                return rst;
            }
            else { return rst; }
        }

        public bool RemoveEtudiant(int id)
        {
            try
            {
                _etudiantRepository.RemoveEtudiant(id);
               
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
