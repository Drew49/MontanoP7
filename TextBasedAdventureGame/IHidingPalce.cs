﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public interface IHidingPlace
    {
        GameObject HiddenObject { get; set; }

        void Search();
    }
}
