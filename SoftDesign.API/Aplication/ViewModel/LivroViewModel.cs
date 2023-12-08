namespace SoftDesign.API.Aplication.ViewModel
{
    public class LivroViewModel
    {
        public string Autor { get; set; }

        public string Titulo { get; set; }

        public DateOnly AnoLancamento { get; set; }

        public IFormFile ImagePath { get; set; }
    }
}
