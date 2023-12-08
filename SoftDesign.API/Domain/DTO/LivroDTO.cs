namespace SoftDesign.API.Domain.DTO
{
    public class LivroDTO
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public DateOnly AnoLancamento { get; set; }

        public string? Capa { get; set; }
    }
}
