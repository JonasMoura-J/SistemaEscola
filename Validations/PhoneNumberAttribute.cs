using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Parsers;

namespace SistemaEscola.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class PhoneNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (string.IsNullOrEmpty((string)value))
            {
                // Phone numbers are optional
                return true;
            }

            var phoneNumber = (string)value;

            if (MatchesFormat(phoneNumber))
            {
                if (IsValidPhoneNumber(phoneNumber))
                {
                    return true;
                }
            }

            return false;
        }

        internal bool MatchesFormat(string phoneNumber)
        {
            if (phoneNumber.Length != 14)
            {
                return false;
            }

            if (phoneNumber[0] != '(')
            {
                return false;
            }

            if (phoneNumber[3] != ')')
            {
                return false;
            }

            if (phoneNumber[4] != ' ')
            {
                return false;
            }

            if (phoneNumber[9] != '-')
            {
                return false;
            }

            return true;
        }

        internal bool IsValidPhoneNumber(string phoneNumber)
        {
            string parsedNumber = PhoneNumberParse.ToNumber(phoneNumber);

            List<int> digits = new List<int>();

            try
            {
                parsedNumber.ToList().ForEach(d => digits.Add(int.Parse(d.ToString())));
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
