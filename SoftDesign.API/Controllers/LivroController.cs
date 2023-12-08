using Microsoft.AspNetCore.Mvc;
using SoftDesign.API.Aplication.ViewModel;
using SoftDesign.API.Domain.Models;

namespace SoftDesign.API.Controllers
{
    [ApiController]
    [Route("api/v1/livro")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository ?? throw new ArgumentException(nameof(livroRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var livros = _livroRepository.GetAll();
            return Ok(livros);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var livros = _livroRepository.GetById(id);
            return Ok(livros);
        }

        [HttpPost]
        public IActionResult Add(LivroViewModel livroViewModel)
        {
            var filePath = Path.Combine("Storage", livroViewModel.ImagePath.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);

            Livro livro = new Livro(livroViewModel.Autor, 
                                     livroViewModel.Titulo, 
                                     livroViewModel.AnoLancamento,
                                     filePath);
            
            _livroRepository.Add(livro);
            return Ok();            
        }

        [HttpPatch]
        public IActionResult PatchLivro(Livro livro)
        {
            _livroRepository.Update(livro);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteLivro(Livro livro)
        {
            _livroRepository.Delete(livro);
            return Ok();
        }
    }
}
