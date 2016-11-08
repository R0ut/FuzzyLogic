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
        
        
        public double min, med1, med2, max;
        public double off = 0;
        public double[] table;
        public int index; 

        //metoda do wykresu zzz(-inf,13)
        public double zzz(double tem)
        {
            
            
            med2 = 11;
            max = 13;

            if (tem <=med2)
                off = 1;
            else if ((tem >= med2) && (tem < max))
                off = (max - tem) / (double)(max - med2);
            else if (tem >= max)
                off = 0;
            return Math.Round(off, 2);
        }
        //metoda do wykresu zz(12,17)
        public double zz(double tem)
        {
            min = 12;
            med1 = 14;
            med2 = 15;
            max = 17;


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
            return Math.Round(off,2);
        }
        //metoda do wykresu z (16,21)
        public double z(double tem)
        {
            min = 16;
            med1 = 18;
            med2 = 19;
            max = 21;


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
            return Math.Round(off, 2);
        }
        //metoda do wykresu ok(20,25)
        public double ok(double tem)
        {
            min = 20;
            med1 = 22;
            med2 = 23;
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
            return Math.Round(off,2);
        }
        //metoda do wykresu c (24,29)
        public double c(double tem)
        {
            min = 24;
            med1 = 26;
            med2 = 27;
            max = 29;


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
            return Math.Round(off,2);
        }
        //metoda do wykresu cc(28,33)
        public double cc(double tem)
        {
            min = 28;
            med1 = 30;
            med2 = 31;
            max = 33;


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
            return Math.Round(off, 2);
        }
        //motoda do wykresu ccc(32,inf)
        public double ccc(double tem)
        {
            min = 32;
            med1 = 34;
            med2 = 35;
            max = 36;


            if (tem < min)
                off = 0;
            else if ((tem >= min) && (tem <= med1))
                off = (tem - min) / (double)(med1 - min);
            else if ((tem >= med1))
                off = 1;
            
            return Math.Round(off, 2);
        }


        //metoda do wyciagniecia maksymalnej wartosci z metod zzz,zz,z,ok,c,cc,ccc
        public double maxValue(double a)
        {
            table = new double[7];

            table[0] = zzz(a);
            table[1] = zz(a);
            table[2] = z(a);
            table[3] = ok(a);
            table[4] = c(a);
            table[5] = cc(a);
            table[6] = ccc(a);


            return table.Max();
        }


        //zwraca numer od 0 do 6 i tak index = 1 wskazuje ze max metoda to zzz() index=1 metoda zz() itd.
        public double getMax(double m1, double m2, double m3, double m4, double m5, double m6, double m7)
        {
            if (m1 > m2 && m1 > m3 && m1 > m4 && m1 > m5 && m1 > m6 && m1 > m7) return index = 0 ;
            else if (m2 > m3 && m2 > m4 && m2 > m5 && m2 > m6 && m2 > m7) return index = 1;
            else if (m3 > m4 && m3 > m5 && m3 > m6 && m3 > m7) return index = 2;
            else if (m4 > m5 && m4 > m6 && m4 > m7) return index = 3;
            else if (m5 > m6 && m5 > m7) return index = 4;
            else if (m6 > m7) return index = 5;
            else return index = 6;
        }

        

    }
}
