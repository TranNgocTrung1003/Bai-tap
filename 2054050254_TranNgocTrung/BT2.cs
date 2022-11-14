﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2054050254_TranNgocTrung
{
    public class BT2
    {
        private int n;
        private List<int> a;
        private int v;

        public BT2(int n, List<int> a)
        {
            if (a.Count() != n + 1)
                throw new ArgumentException("Invalid Data");
            this.n = n;
            this.a = a;
        }

        public BT2(int n, int v)
        {
            this.n = n;
            this.v = v;
        }

        public int Cal(double x)
        {
            int result = 0;
            for (int i = 0; i <= this.n; i++)
            {
                result += (int)(a[i] * Math.Pow(x, i));
            }
            return result;
        }
    } 
}
