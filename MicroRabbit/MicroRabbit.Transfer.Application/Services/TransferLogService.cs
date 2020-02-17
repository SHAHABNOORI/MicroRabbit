using System.Collections.Generic;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferLogService: ITransferLogService
    {
        private readonly ITransferLogRepository _repository;
        private readonly IEventBus _bus;

        public TransferLogService(ITransferLogRepository repository, IEventBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            var result = _repository.GetTransferLogs();
            return result;
        }
    }
}