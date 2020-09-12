using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_project.Helpers
{
    public static class Extensions
    {

        public static int CalculateAge(this DateTime birthday)
        {

            var age = DateTime.Today.Year - birthday.Year;
            if (birthday.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
    }
}
