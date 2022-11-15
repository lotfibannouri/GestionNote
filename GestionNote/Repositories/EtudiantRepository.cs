using GestionNote.Models;

namespace GestionNote.Repositories
{
    public class EtudiantRepository
    {
        private readonly AppDbContext _appDbContext;
        public EtudiantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void AddEtudiant(Etudiant etudiant)
        {

            _appDbContext.Etudiant.Add(etudiant);
            _appDbContext.SaveChanges();

        }

        public void EditEtudiant(Etudiant etudiant)
        {
            _appDbContext.Etudiant.Update(etudiant);
            _appDbContext.SaveChanges();
        }

        public Etudiant? GetEtudiantByID(int id)
        {
            return _appDbContext.Etudiant.Find(id);
        }


        public List<Etudiant>? GetEtudiants()
        {
            return _appDbContext.Etudiant.ToList();
        }

        public void RemoveEtudiant(int id)
        {
            _appDbContext.Etudiant.Remove(this.GetEtudiantByID(id));
            _appDbContext.SaveChanges();
        }
    }
}
