using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Passos_iniciais_com_.NET.Models.SerializacaoComJSON
{
    public class AprendendoSerializacao
    {
        public static void Serializar(string caminho)
        {
            string jsonString = File.ReadAllText(caminho);
            var arquivoDesserializado = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
            foreach(var objeto in arquivoDesserializado!)
            {
                Console.WriteLine($"{objeto.Key}: {objeto.Value}");
            }

            Console.WriteLine("Adicionar Novas informações ao json: ");
            var chave = Console.ReadLine();
            var valor = Console.ReadLine();

            arquivoDesserializado.Add(chave!, valor!);

            var jsonSerializado = JsonSerializer.Serialize(arquivoDesserializado, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, jsonSerializado);
        }

        public static void AdicionarInformacoesJSON()
        {
            
        }
    }
}