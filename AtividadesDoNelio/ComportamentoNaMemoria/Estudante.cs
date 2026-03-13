namespace AtividadesDoNelio.ComportamentoNaMemoria
{
    public partial class Atividade_QuartosOcupados
    {
        public class Estudante
        {
            public string? Nome { get; private set; }
            public string? setName 
            {
                set => Nome = value;
            }
            public string? Email { get; private set; }
            public Estudante() { }
            public Estudante(string nome, string email)
            {
                this.Nome = nome;
                this.Email = email;
            }
           
        }
    }
}
