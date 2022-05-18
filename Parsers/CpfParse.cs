using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Parsers
{
    public static class CpfParse
    {
        public static string ToNumber(string cpfDigit)
        {
            string parsedCpf;

            parsedCpf = cpfDigit.Replace(".", string.Empty);
            parsedCpf = parsedCpf.Replace("-", string.Empty);

            return parsedCpf;
        }
    }
}
