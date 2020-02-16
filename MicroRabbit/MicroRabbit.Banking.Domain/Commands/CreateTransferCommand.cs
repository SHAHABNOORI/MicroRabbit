﻿namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from,int to,decimal amount)
        {
            FromAccount = from;
            ToAccount = to;
            TransferAmmount = amount;
        }
    }
}