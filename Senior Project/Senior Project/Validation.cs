using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace Senior_Project
{
    public class Validation
    {
        public Validation()
        {
            
        }

        public static void validateStringAlphaNumeric(string s, string fromInput)
        {
            Regex r = new Regex("^[a-zA-Z0-9\\s]*$");
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid characters");
                }
            }
        }
        public static void validateStringAlpha(string s, string fromInput)
        {
            Regex r = new Regex("^[a-zA-Z\\s]*$");
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid characters \nCan Contain Alpha Characters.");
                }
            }
        }
        public static void validateStringAlphaPeriod(string s, string fromInput)
        {
            Regex r = new Regex("^[a-zA-Z\\s\\.]*$");
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid characters \nCan Contain Alpha Characters.");
                }
            }
        }
        public static void validateStringAlphaNumericPeriod(string s, string fromInput)
        {
            Regex r = new Regex("^[a-zA-Z0-9\\.\\s]*$");
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid character \nCan Contain AlphaNumeric Characters, periods and spaces");
                }
            }
        }
        public static void validateStringAddress2(string s, string fromInput)
        {
            Regex r = new Regex("^[a-zA-Z0-9\\.\\s]*$");
            if (r.IsMatch(s))
            {
            }
            else
            {
                throw new System.FormatException(fromInput + " Contains invalid character \nCan Contain AlphaNumeric Characters, periods and spaces");
            }
            
        }
        public static void validateNumeric(string s, string fromInput)
        {
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                Regex r = new Regex("^[0-9]*$");
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid characters \nCan Contain Numbers");
                }
            }
        }
        public static void validateCost(string s, string fromInput)
        {
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
            else
            {
                Regex r = new Regex("^[0-9\\.\\,]*$");
                if (r.IsMatch(s))
                {
                }
                else
                {
                    throw new System.FormatException(fromInput + " Contains invalid characters \nCan Contain Numeric Characters and Periods");
                }
            }
        }
        public static void validateNotBlank(string s, string fromInput)
        {
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Cannot Be left Blank");
            }
        }
        public static void validateNotSelected(string s, string fromInput)
        {
            if (s == "")
            {
                throw new System.FormatException(fromInput + " Needs To Be Selected");
            }
        }
    }
}
