using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Parsers;

namespace SistemaEscola.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class MobilePhoneNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty((string)value))
            {
                // Phone numbers are optional
                return ValidationResult.Success;
            }

            var phoneNumber = (string)value;

            if (MatchesFormat(phoneNumber))
            {
                if (IsValidPhoneNumber(phoneNumber))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage = "Número de telefone celular inválido.");
        }

        internal bool MatchesFormat(string phoneNumber)
        {
            if (phoneNumber.Length != 16)
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

            if (phoneNumber[6] != ' ')
            {
                return false;
            }

            if (phoneNumber[11] != '-')
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
