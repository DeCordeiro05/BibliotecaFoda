using Microsoft.AspNetCore.Mvc;

namespace BibliotecaDeLivros.Models
{
    public class BibliotecaModels
    {
        public int Id { get; set; }
        public string ? Descricao { get; set; }
        public string ? locacao { get; set; }
        public string ? Titulo { get; set; }
        public string ? Autor {  get; set; }
        public int Ano {  get; set; }
        public int Quantidade { get; set; }

    }
}
