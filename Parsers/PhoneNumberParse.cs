using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Parsers
{
    public static class PhoneNumberParse
    {
        public static string ToNumber(string phoneNumber)
        {
            string parsedNumber;

            parsedNumber = phoneNumber.Replace("(", string.Empty);
            parsedNumber = parsedNumber.Replace(")", string.Empty);
            parsedNumber = parsedNumber.Replace(" ", string.Empty);
            parsedNumber = parsedNumber.Replace("-", string.Empty);

            return parsedNumber;
        }
    }
}
