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
            if (string.IsNullOrEmpty(cpfDigit))
            {
                return string.Empty;
            }

            string parsedCpf;

            parsedCpf = cpfDigit.Replace(".", string.Empty);
            parsedCpf = parsedCpf.Replace("-", string.Empty);

            return parsedCpf;
        }

        public static string ToDigit(string cpfNumber)
        {
            if (string.IsNullOrEmpty(cpfNumber))
            {
                return string.Empty;
            }

            string parsedCpf;

            parsedCpf = cpfNumber.Insert(3, ".");
            parsedCpf = parsedCpf.Insert(7, ".");
            parsedCpf = parsedCpf.Insert(11, "-");

            return parsedCpf;
        }
    }
}
