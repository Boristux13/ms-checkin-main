using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {

        public Vuelo() // detallar esta clase le corresponde a favio 
        {
            Id = Guid.NewGuid();
        }


    }
}
