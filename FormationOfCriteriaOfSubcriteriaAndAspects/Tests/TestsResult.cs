using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tests
{
    public class TestsResult
    {
        public static class proverka
        {
            public static int GetEmailStrength(string email)
            {

                if (string.IsNullOrEmpty(email))
                {
                    return 0;
                }
                int result = 0;


                if (Math.Max(email.Length, 20) > 20)
                {
                    result++;
                }

                if (Regex.Match(email, "[a-z]").Success)
                {
                    result++;
                }
                
                if (Regex.Match(email, "[A-Z]").Success)
                {
                    result++;
                }
                
                if (Regex.Match(email, "[0-9]").Success)
                {
                    result++;
                }

                if (Regex.Match(email, "[@]").Success)
                {
                    result++;
                }

                if (Regex.Match(email, "[.]").Success)
                {
                    result++;
                }

                if (Regex.Match(email,@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)
                {
                    result++;
                }
                return result;
            }

            public static int CheckingForUniqueness(string telefon)
            {
                if (string.IsNullOrEmpty(telefon))
                {
                    return 0;
                }
                int result = 0;

                if (Regex.Match(telefon,@"^(?=.*[0-9])\S{11,11}$").Success)
                {
                    result++;
                }
                return result;
            }
        }
    }
}
