using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_15
{
    class Number:Form1
    {
        public int A;
        public int BJ;
        public int C;
        public int DJ;
        private int v;
        private int v1;
        private int v2;

        public Number(int v)
        {
            this.v = v;
        }

        public Number(int v, int v1, int v2) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Number(int a, int bj, int c, int dj)
        {
            A = a;
            BJ = bj;
            C = c;
            DJ = dj;

        }

   
        public static Number operator +(Number num1, Number num2)
        {
            return new Number((num1.A + num2.BJ) + (num1.C + num2.DJ));
        }
        public static Number operator -(Number num1, Number num2)
        {
            return new Number((num1.A - num2.BJ) - (num1.C - num2.DJ));
        }
        public static Number operator *(Number num1, Number num2)
        {
            return new Number((num1.A + num2.DJ) * (num1.C + num2.DJ));
        }
    }
 }



    


