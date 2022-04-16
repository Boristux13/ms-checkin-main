using Pedidos.Domain.Model.Checkins.ValueObjects;
using Pedidos.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Checkins
{
    public class Checkin : AggregateRoot<Guid>
    {
        public Guid ClienteId { get; private set; }
        public Guid VueloId { get; private set; }
        public String Pasaporte { get; private set; }
        public NumeroAsiento NroAsiento { get; private set; } 
        
        public int NroPuerta { get; private set; }

        public DateTime Fecha { get; private set; }
        public ICollection<Equipaje> ListaEquipaje { get; private set; }



        public Checkin() // constructo de la clase
        {
            Id = Guid.NewGuid();
            ListaEquipaje= new List<Equipaje>();
        }
        public void RegistrarCheckin(Guid clienteId, Guid vueloId, string pasaporte, int nro_asiento, int nro_puerta)
        {
            ClienteId = clienteId;
            VueloId = vueloId;
            Pasaporte = pasaporte;
            NroAsiento = nro_asiento;
            Fecha = DateTime.Now;
            NroPuerta = nro_puerta;

        }
        public void AgregarEquipaje(decimal carga, string etiqueta)
        {            
            Equipaje equipaje= new Equipaje(Id,carga,etiqueta);
            ListaEquipaje.Add(equipaje);           
        }
    }
}
