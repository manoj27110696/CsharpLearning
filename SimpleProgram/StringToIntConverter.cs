using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    class StringToIntConverter
    {
        public int convert(string number)
        {
            try
            {
                int convertedNumber;
                bool isConvertedSuccessfully = int.TryParse(number, out convertedNumber);
                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Conversion not successful");
                }
                return convertedNumber;
            }

            catch (Exception ex)
            {
                throw new Exception("new message ",ex);
            }
        }
    }
}


