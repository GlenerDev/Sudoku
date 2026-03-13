using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDoNelio.ComportamentoNaMemoria
{
    public partial class Atividade_QuartosOcupados
    {
        private List<Quarto> listquarto = new List<Quarto>();
        public Atividade_QuartosOcupados()
        {
           
        }
        public Quarto ObterQuartoPorId(int numero_index, List<Quarto> arrayL) => arrayL.FirstOrDefault(x => x.Numero == numero_index)!;
        public void EntradadaDados(string name, string email, int numero)
        {
            if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(email))
            {
                listquarto.FirstOrDefault(n => n.Numero == numero);
                listquarto.Add(new Quarto(new Estudante(name, email)));
            }
        }
        public void ResolverQuestao()
        {
            Console.Write("Entre com a quantidade de quartos que precisam ser ocupados: ");
            var quantidadeDeQuartos = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeDeQuartos; i++)
            {

            }
            throw new Exception("Aconteceu algum erro na entrada do dado a seguir " + quantidadeDeQuartos);
        }
        public void initialApp() 
        {
            int[] inputsinicial = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            for (int i = 0; i < listquarto.Count && i < inputsinicial.Length; i++)
                listquarto[i].SetNumero = inputsinicial[i];
        }
    }
}
