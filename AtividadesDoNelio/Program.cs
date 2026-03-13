// See https://aka.ms/new-console-template for more information
using AtividadesDoNelio.algoritmos;
using AtividadesDoNelio.ComportamentoNaMemoria;
using System.Drawing;
using AtividadesDoNelio.Sudokko;

//var tarefaHotel = new Atividade_QuartosOcupados();
//// tarefaHotel.ResolverQuestao();
//var by = new Algoritmos();
//List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Console.WriteLine(by.bynarySearch(lista, 10));
//var su = new PlanilhaDaMatriz();
//for (int cont = 0; cont < 9; cont++)
//    for (int i = 0; i < 3 - 1; i++)
//    {
//        for (int f = 0; f < 81; f++)
//        {
//            su.matriz[i, f] = lista[f];
//        }
//    }
//foreach (var item in su.matriz)
//{
//    Console.WriteLine(item);
//}
testeFunction test = new testeFunction();
test.fun = test.testedelegate1;
test.fun();
test.fun = test.testedelegate2;
test.fun.Invoke();
test.fun();
test.fun = test.testedelegate3;
test.fun();


public class testeFunction
{
    public delegate void Callback();
    public Callback fun;
    public void testedelegate1() => Console.WriteLine("Glener");
    public void testedelegate2() => Console.WriteLine("Glener2");
    public void testedelegate3() => Console.WriteLine("Glener3");

    
}
