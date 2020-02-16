using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int fromAccount, int account, decimal transferAmmount)
        {
            FromAccount = fromAccount;
            ToAccount = account;
            TransferAmmount = transferAmmount;
        }

        public int FromAccount { get; private set; }

        public int ToAccount { get; private set; }

        public decimal TransferAmmount { get; private set; }
    }
}