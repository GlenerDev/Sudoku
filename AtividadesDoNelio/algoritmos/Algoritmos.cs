using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDoNelio.algoritmos
{
    internal class Algoritmos
    {
        
        public List<int> listNumber = new List<int> { 1,2,3,4,5,6,7,8,9,0};

        public int bynarySearch(List<int> arr, int item) 
        {
            var baixo = 0;//mais baixo possivel
            var alto = arr.Count - 1;// o mais alto possivel 


            while (baixo <= alto) // enquanto não acabar os chutes não vai mais dar true

            {
                var meio = (baixo + alto) / 2;// declaraçao de variavel do meio da lista

                var chute = arr[meio];// declaraçao de variavel de chute atual

                if (chute == item) return meio;// se acaso o chute ser o item procurado sera retornado

                if (chute > item) alto = meio - 1;// se o item for menor que o chute ele subtrara um a menos do meio


                else  baixo = meio + 1;// se o item for maior que o chute ele somara mais um do meio
            }
            return -1; // retornar -1 se o item não for encontrado
        }



    }
}
