﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253019HW1
{
    class InputValidation
    {
        /**
       * Try parse or die dude die!
       */
        public int TryToInt32(string value)
        {
            int result = 1;

            try
            {
                result = Convert.ToInt32(value);
                return result = 1;
            }
            catch
            {
                result = 0;
                return result;
            }
        }
    }
}
