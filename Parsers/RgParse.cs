using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Parsers
{
    class RgParse
    {
        public static string ToNumber(string rgDigit)
        {
            string parsedRg;

            parsedRg = rgDigit.Replace(".", string.Empty);
            parsedRg = parsedRg.Replace("-", string.Empty);

            return parsedRg;
        }
    }
}
