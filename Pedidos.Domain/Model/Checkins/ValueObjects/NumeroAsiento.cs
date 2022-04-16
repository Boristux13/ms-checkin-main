using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Checkins.ValueObjects
{
    public record NumeroAsiento: ValueObject
    {
        public int Value { get; }
        public NumeroAsiento(int value)
        {
            if (value <= 0)
            {
                throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
            }
            Value = value;
        }

        public static implicit operator int(NumeroAsiento value)
        {
            return value.Value;
        }

        public static implicit operator NumeroAsiento(int value)
        {
            return new NumeroAsiento(value);
        }
    }
}
