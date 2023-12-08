using Microsoft.EntityFrameworkCore;
using SoftDesign.API.Aplication.ViewModel;
using SoftDesign.API.Domain.DTO;
using SoftDesign.API.Domain.Models;

namespace SoftDesign.API.Infraestructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public List<LivroDTO> GetAll()
        {
            return _context.Livros.
                Select(x =>
                new LivroDTO()
                {
                    Id = x.Id,
                    Autor = x.Autor,
                    Titulo = x.Titulo,
                    AnoLancamento = x.AnoLancamento,
                    Capa = x.Capa
                }).ToList();
        }

        public Livro GetById(int id)
        {
            return _context.Livros.Find(id);
        }

        public void Delete(Livro livro)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }

       public void Update(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
