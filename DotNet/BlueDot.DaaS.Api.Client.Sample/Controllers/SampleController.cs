using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlueDot.DaaS.Api.Client.Sample.Models;
using BlueDot.DaaS.Api.Client.Sample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlueDot.DaaS.Api.Client.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> _logger;
        private readonly IBluedotDaasService _blueDotDaasService;

        /// <summary>
        /// Creates an instance of <see cref="SampleController"/>
        /// </summary>
        /// <param name="logger">the logger</param>
        /// <param name="blueDotDaasService">the blueDotDaasService</param>
        public SampleController(
            ILogger<SampleController> logger,
            IBluedotDaasService blueDotDaasService)
        {
            _logger = logger;
            _blueDotDaasService = blueDotDaasService;
        }

        /// <summary>
        /// Get list of diseases
        /// </summary>
        /// <param name="cancellationToken">the cancellation token</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Disease>> GetDiseases(CancellationToken cancellationToken)
        {
            _logger.LogTrace("{method} hit..", nameof(GetDiseases));
            return await _blueDotDaasService.GetDiseases(cancellationToken);
        }
    }
}
