using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.AsyncEAwait
{
    public class AprendendoProgramacaoAssincrona
    {
        public static async Task TestandoAsync()
        {
            Console.WriteLine("Testando Antes do Await");
            await Task.Delay(5000);
            Console.WriteLine("Testando Depois do Await");
        }

        public static void TestandoSemAsync()
        {
            Console.WriteLine("Testando método sem Async");
        }
    }
}