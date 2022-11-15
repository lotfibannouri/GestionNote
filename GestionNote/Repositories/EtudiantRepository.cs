using GestionNote.Models;

namespace GestionNote.Repositories
{
    public class EtudiantRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        public EtudiantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void Delete(int id)
        {
            _appDbContext.Set<T>().Remove(this.Get(id));
            _appDbContext.SaveChanges();
        }

        public T Get(long id)
        {
            return _appDbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _appDbContext.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _appDbContext.Set<T>().Update(entity);
            _appDbContext.SaveChanges();
        }

        //public void AddEtudiant(T objet)
        //{

        //    _appDbContext.Set<T>().Add(objet);
        //    _appDbContext.SaveChanges();

        //}

        //public void EditEtudiant(T objet)
        //{
        //    _appDbContext.Set<T>().Update(objet);
        //    _appDbContext.SaveChanges();
        //}

        //public T? GetEtudiantByID(int id)
        //{
        //    return _appDbContext.Set<T>.Find(id);
        //}


        //public List<T>? GetEtudiants()
        //{
        //    return _appDbContext.Set<T>().ToList();
        //}

        //public void RemoveEtudiant(int id)
        //{
        //    _appDbContext.Set<T>.Remove(this.GetEtudiantByID(id));
        //    _appDbContext.SaveChanges();
        //}
    }
}
