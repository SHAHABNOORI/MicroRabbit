using System.Collections.Generic;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferLogService _service;

        public TransferController(ITransferLogService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            var result = _service.GetTransferLogs();
            return Ok(result);
        }
    }
}
