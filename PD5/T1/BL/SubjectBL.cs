﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1.BL
{
    public class SubjectBL
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;

        public SubjectBL() 
        {
        }
        
        public SubjectBL (string code, int creditHours, string subjectType, int subjectFee)
        {
            this.code = code;      
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
    }
}
