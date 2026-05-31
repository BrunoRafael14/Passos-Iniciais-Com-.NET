using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.ExceptionsKek
{
    public class NomeErradoKekException : Exception
    {
        public NomeErradoKekException(string mensagem) : base(mensagem)
        {
            
        }
    }
}