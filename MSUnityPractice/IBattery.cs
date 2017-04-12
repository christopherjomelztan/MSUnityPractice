﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnityPractice
{
    public interface IBattery
    {
        bool SelfCheck();

        int ChargeRemaining();
  
        string Manufacturer();

        string SerialNumber();
    }
}
