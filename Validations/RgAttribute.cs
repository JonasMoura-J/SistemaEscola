using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SistemaEscola.Parsers;
using System.Linq;

namespace SistemaEscola.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class RgAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var rgDigit = (string)value;

            if (MatchesFormat(rgDigit))
            {
                if (IsValidRgDigit(rgDigit))
                {
                    return true;
                }
            }

            return false;
        }

        internal bool MatchesFormat(string rgDigit)
        {
            if (rgDigit.Length != 12)
            {
                return false;
            }

            if (rgDigit[2] != '.')
            {
                return false;
            }

            if (rgDigit[6] != '.')
            {
                return false;
            }

            if (rgDigit[10] != '-')
            {
                return false;
            }

            return true;
        }

        internal bool IsValidRgDigit(string rgDigit)
        {
            string parsedRg = RgParse.ToNumber(rgDigit);

            List<int> digits = new List<int>();

            try
            {
                parsedRg.ToList().ForEach(d => digits.Add(int.Parse(d.ToString())));
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
