namespace SistemaEscola.Parsers
{
    public static class PhoneNumberParse
    {
        public static string ToNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return string.Empty;
            }

            string parsedNumber;

            parsedNumber = phoneNumber.Replace("(", string.Empty);
            parsedNumber = parsedNumber.Replace(")", string.Empty);
            parsedNumber = parsedNumber.Replace(" ", string.Empty);
            parsedNumber = parsedNumber.Replace("-", string.Empty);

            return parsedNumber;
        }

        public static string ToDigit(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return string.Empty;
            }

            string parsedNumber;

            parsedNumber = phoneNumber.Insert(0, "(");
            parsedNumber = parsedNumber.Insert(3, ")");
            parsedNumber = parsedNumber.Insert(4, " ");
            parsedNumber = parsedNumber.Insert(9, "-");

            return parsedNumber;
        }

        public static string ToMobileDigit(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return string.Empty;
            }

            string parsedNumber;

            parsedNumber = phoneNumber.Insert(0, "(");
            parsedNumber = parsedNumber.Insert(3, ")");
            parsedNumber = parsedNumber.Insert(4, " ");
            parsedNumber = parsedNumber.Insert(6, " ");
            parsedNumber = parsedNumber.Insert(10, "-");

            return parsedNumber;
        }
    }
}
