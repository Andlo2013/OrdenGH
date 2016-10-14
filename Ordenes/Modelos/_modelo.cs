using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Modelos
{
    public class _modelo
    {
        private string m_errorsMessage = "";
        private bool m_isValid = false;
        private int m_errorsNumber = 0;

        private IEnumerable<ValidationResult> _validate(object obj)
        {
            m_errorsMessage = "";
            m_errorsNumber = 0;
            m_isValid = true;
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, context, validationResults, true);
            return validationResults;
        }

        public bool _isValid()
        {
            try {
                var errors=_validate(this);
                
                foreach (var error in errors)
                {
                    _addError(error.ErrorMessage);
                }
            }
            catch(Exception ex)
            {
                m_isValid = false;
                m_errorsMessage="ERROR: Al intentar validar el modelo\nDescripción:\n"+ex.Message;
            }
            return m_isValid;
        }

        protected void _addError(string error)
        {
            m_isValid = false;
            m_errorsNumber++;
            string numError = "";
            numError = m_errorsNumber.ToString().PadLeft(3, '0');
            m_errorsMessage += numError + "-" + error+ "\n";
        }

        public string pro_getErrrors
        {
            get { return m_errorsMessage; }
        }

        public int pro_getTotalErrors
        {
            get { return m_errorsNumber; }
        }
    }
}
