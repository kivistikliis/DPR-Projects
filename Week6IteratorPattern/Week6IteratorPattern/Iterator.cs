﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public interface Iterator
    {
        bool hasNext();
        Student next();
    }
}
