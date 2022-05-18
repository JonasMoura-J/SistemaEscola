using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SistemaEscola.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class DateAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;

        public DateAttribute(string minDate)
        {
            try
            {
                _minDate = DateTime.ParseExact(minDate, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                _maxDate = DateTime.Now;

                if (_maxDate < _minDate)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DateAttribute(string minDate, string maxDate)
        {
            try
            {
                _minDate = DateTime.ParseExact(minDate, "dd/MM/yyyy", new CultureInfo("pt-BR"));
                _maxDate = DateTime.ParseExact(maxDate, "dd/MM/yyyy", new CultureInfo("pt-BR"));

                if (_maxDate < _minDate)
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }          

        public override bool IsValid(object value)
        {
            var date = (DateTime)value;

            if (date != DateTime.MinValue)
            {
                if (date >= _minDate && date <= _maxDate)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
