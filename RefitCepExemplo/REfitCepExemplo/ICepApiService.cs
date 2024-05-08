using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Refit;


namespace RefitCepExample
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        //descrevemos aqui o método da APi que usaremos e ja deixamos o espaço 
        //para colocação do cep no corpo do endereço, que sera substituido em tempo de executação pelo cep 
        //que for passado como parametro
        Task<CepResponse> GetAddressAsync(string cep);
        //Aqui é declarado como sera realizado o chamado para a api
        //vemos na assinatura do método que é mencionada a Classe
        //“CepResponse”, como o item que será retornado, já o método GetAddressAsync, recebe um parâmetro do tipo “string” que será inserido no endereço escrito na linha anterior.
    }
}

