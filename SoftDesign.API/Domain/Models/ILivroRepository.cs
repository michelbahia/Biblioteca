using SoftDesign.API.Domain.DTO;

namespace SoftDesign.API.Domain.Models
{
    public interface ILivroRepository
    {
        void Add(Livro livro);
        List<LivroDTO> GetAll();
        void Update(Livro livro);
        void Delete(Livro livro);
        Livro? GetById(int id);
    }
}
