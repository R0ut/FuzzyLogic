using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wykresy
{
    class wykresy
    {
        
        
        public int min, med1, med2, max;
        public double off = 0;
        
        public double cold( int tem)
        {
            min = -30;
            med1 = -25;
            med2 = -10;
            max = 0;


            if (tem < min)
                off = 0;
            else if ((tem >= min) && (tem <= med1))
                off = (tem - min) / (double)(med1 - min);
            else if ((tem >= med1) && (tem < med2))
                off = 1;
            else if ((tem >= med2) && (tem < max))
                off = (max - tem) / (double)(max - med2);
            else if (tem >= max)
                off = 0;
            return off;
        }

        public double veryCold(int tem)
        {
            min = -50;
            med1 = -30;
            max = -25;
            

            if (tem < min)
                off = 0;
            else if ((tem >= min) && (tem <= med1))
                off = 1;
            else if ((tem >= med1) && (tem < max))
                off = (max - tem) / (double)(max - med1);
            else if (tem >= max)
                off = 0;

            return off;
        }



        public double warm(int tem)
        {
            min = -5;
            med1 = 7;
            med2 = 19;
            max = 25;


            if (tem < min)
                off = 0;
            else if ((tem >= min) && (tem <= med1))
                off = (tem - min) / (double)(med1 - min);
            else if ((tem >= med1) && (tem < med2))
                off = 1;
            else if ((tem >= med2) && (tem < max))
                off = (max - tem) / (double)(max - med2);
            else if (tem >= max)
                off = 0;
            return off;
        }



        public double veryWarm(int tem)
        {
            min = 20;
            med1 = 30;
            med2 = 40;
            max = 50;


            if (tem < min)
                off = 0;
            else if ((tem >= min) && (tem <= med1))
                off = (tem - min) / (double)(med1 - min);
            else if ((tem >= med1) && (tem < med2))
                off = 1;
            else if ((tem >= med2) && (tem < max))
                off = (max - tem) / (double)(max - med2);
            else if (tem >= max)
                off = 0;
            return off;
        }
    }
}
