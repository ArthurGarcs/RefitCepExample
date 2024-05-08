using Refit;
using System;
using System.Threading.Tasks;


namespace RefitCepExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
            //declara o objeto cepClient que sera isntalado pelo Refit como um serviço que possua 
            //os metodos da interface ICepApiService 
            string meuCep = "13300390";
            Console.WriteLine("Consultando dados do Cep:" + meuCep);


            var address = await cepClient.GetAddressAsync(meuCep);
            // nesta linha é criado um objweto "address" atráves do retorno do metodo GetAddressAsync com o cep informado 



            Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}" +
                $"\nEstado:{address.Uf}\nCódigo Ibge:{address.Ibge}");
            Console.ReadKey();
        }
    }
}