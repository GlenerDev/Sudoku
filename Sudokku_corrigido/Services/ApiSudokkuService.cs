using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sudokku_corrigido.Services
{
    internal class ApiSudokkuService
    {
        private static string Keyauthentic { get; set; }
        private static string Typeauthentic { get; set; }
        private static string Typeresponse { get; set; }

        public ApiSudokkuService(string keyauthentic, string typeauthentic, string ?typeresponse)
        {
            Keyauthentic = keyauthentic;
            Typeauthentic = typeauthentic;
            Typeresponse = typeresponse;
        }
        public static async Task<string> GenerateSudokku(string difficult_, bool solution_, bool array_ = false)
        {
            var client = new HttpClient();//intstancia de um objeto httpClient;
            client.DefaultRequestHeaders.Add(Typeauthentic, Keyauthentic);// autenticaçao da rota

            var sudokkuObject  = new 
            {
                difficulty = difficult_,
                solution = solution_,
                array = array_
            }; // criação do objeto
            
            string jsonseralize = JsonSerializer.Serialize(sudokkuObject);// serializar o objeto para string

            var content = new StringContent(jsonseralize, Encoding.UTF8,Typeresponse);//cria uma nova instancia da classe stringcontent

            HttpResponseMessage response = await client.PostAsync("https://you-do-sudoku-api.vercel.app/api", content);//obtem a resposta da requisiçao

            string result = await response.Content.ReadAsStringAsync();//retornar a resposta como texto assincronicamente
            if (!response.IsSuccessStatusCode)//verifica se deu certo a requisiçao
            {
                throw new Exception($"Error: {response.StatusCode}\n{result}");
            };
            return result;
        }
        
    }
}
