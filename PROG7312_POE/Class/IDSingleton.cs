﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class
{
    public class IDSingleton
    {
        public static int idcount = 0;

        public IDSingleton() {
        }

        public void IDPlus()
        {
            idcount++;
        }
    }
}