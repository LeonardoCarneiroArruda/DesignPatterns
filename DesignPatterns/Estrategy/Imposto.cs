﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Estrategy
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);

    }
}
