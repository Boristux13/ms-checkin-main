using Pedidos.Domain.Model.Checkins.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Checkins
{
    public class Equipaje : Entity<Guid>
    {
        //TODO: Crear value objects para las propiedades
        public Guid CheckinId { get; private set; }
        public decimal Carga { get; private set; } //debe ser valkue object mayor a 0 tipo deciomal con unidad ed mediad gramos kilo
        public NumeroEtiqueta Etiqueta { get; private set; } //debe ser un value object text no vacio

        internal Equipaje(Guid checkinId, decimal carga, string etiqueta)
        {
            Id = Guid.NewGuid();
            CheckinId = checkinId;
            Carga = carga;
            Etiqueta = etiqueta;

        }
    }
}
