using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Checkins.ValueObjects
{
    public record NumeroEtiqueta : ValueObject
    {
        public string Value { get; }

        public NumeroEtiqueta(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del numero
            Value = value;
        }


        public static implicit operator string(NumeroEtiqueta value)
        {
            return value.Value;
        }

        public static implicit operator NumeroEtiqueta(string value)
        {
            return new NumeroEtiqueta(value);
        }



    }
}
