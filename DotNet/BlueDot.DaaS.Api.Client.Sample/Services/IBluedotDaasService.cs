using BlueDot.DaaS.Api.Client.Sample.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlueDot.DaaS.Api.Client.Sample.Services
{
    public interface IBluedotDaasService
    {
        Task<IEnumerable<Disease>> GetDiseases(CancellationToken cancellationToken);
    }
}
