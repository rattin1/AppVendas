namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string Valor { get; set; }
        public string QtadeEstoque { get; set; }
        public bool CadastroAtivo { get; set; }

        /* Chave Estrangeira */
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
