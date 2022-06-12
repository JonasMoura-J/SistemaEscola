using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Parsers;

namespace SistemaEscola.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpfDigit = (string)value;

            if (MatchesFormat(cpfDigit))
            {
                if (IsValidCpfDigit(cpfDigit))
                {
                    return true;
                }
            }

            return false;
        }

        internal bool MatchesFormat(string cpfDigit)
        {
            if (cpfDigit.Length != 14)
            {
                return false;
            }

            if (cpfDigit[3] != '.')
            {
                return false;
            }

            if (cpfDigit[7] != '.')
            {
                return false;
            }

            if (cpfDigit[11] != '-')
            {
                return false;
            }

            return true;
        }

        internal bool IsValidCpfDigit(string cpfDigit)
        {
            string parsedCpf = CpfParse.ToNumber(cpfDigit);

            if (parsedCpf == "11111111111" || parsedCpf == "22222222222")
            {
                return false;
            }

            List<int> digits = new List<int>();

            try
            {
                parsedCpf.ToList().ForEach(d => digits.Add(int.Parse(d.ToString())));
            } catch {
                return false;
            }

            int result = 0;
            int counter = 10;

            int firstDigit = digits[9];
            int secondDigit = digits[10];

            // First Digit Calculation
            for (int i = 0; i < 9; i++)
            {
                result += digits[i] * counter;
                counter--;
            }

            result %= 11;

            if (result < 2)
            {
                result = 0;
            } else
            {
                result = 11 - result;
            }

            if (result != firstDigit)
            {
                return false;
            }

            // Second Digit Calculation
            counter = 11;
            result = 0;

            for (int i = 0; i < 10; i++)
            {
                result += digits[i] * counter;
                counter--;
            }

            result %= 11;

            if (result < 2)
            {
                result = 0;
            }
            else
            {
                result = 11 - result;
            }

            if (result != secondDigit)
            {
                return false;
            }

            return true;
        }
    }
}
