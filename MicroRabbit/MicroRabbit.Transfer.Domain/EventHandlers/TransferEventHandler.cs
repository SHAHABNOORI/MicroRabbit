using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Evetns;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler:IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferLogRepository _transferLogRepository;

        public TransferEventHandler(ITransferLogRepository transferLogRepository)
        {
            _transferLogRepository = transferLogRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferLogRepository.Add(new TransferLog()
            {
                FromAccount = @event.FromAccount,
                ToAccount = @event.ToAccount,
                TransferAmmount = @event.TransferAmmount
            });
            return Task.CompletedTask;
        }
    }
}