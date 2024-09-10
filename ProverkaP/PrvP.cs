using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProverkaP
{
    public class PrvP
    {
        public int CheckPass (string a) {

            int resultate = 0;

            if (Regex.IsMatch(a, @"\d"))
            {
                resultate++;
            }
            if (Regex.IsMatch(a, @"[A-Z]"))
            {
                resultate++;
            }
            if (Regex.IsMatch(a, @"[a-z]"))
            {
                resultate++;
            }
            if (Regex.IsMatch(a, @"[\W_]")) {
                resultate++;
            }
            if (a.Length >= 10)
            {
                resultate++;
            }

            return resultate;

        }

        
        
    }
}
