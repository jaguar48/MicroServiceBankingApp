using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        [HttpGet]
        public IActionResult GetTransferLogs()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
