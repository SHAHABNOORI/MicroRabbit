using System.Collections.Generic;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _repository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository repository, IEventBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            var result = _repository.GetAccounts();
            return result;
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.FromAccount,
                accountTransfer.ToAccount, accountTransfer.TransferAmmount);
            _bus.SendCommand(createTransferCommand);
        }
    }
}