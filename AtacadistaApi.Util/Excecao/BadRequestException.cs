using System;

namespace AtacadistaApi.Util.Excecao
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string erro) : base(erro) { }
    }
}
