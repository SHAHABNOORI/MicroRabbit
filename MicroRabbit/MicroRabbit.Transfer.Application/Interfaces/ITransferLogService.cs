using System.Collections.Generic;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferLogService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}