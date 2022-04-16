using Pedidos.Domain.Model.Checkins;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Repositories
{
    public interface ICheckinRepository : IRepository<Checkin, Guid>
    {
        Task UpdateAsync(Checkin obj);

        Task RemoveAsync(Checkin obj);

    }
}
