﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticaret.Core.ValueObjects
{
    internal class Money
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
