using System.Collections.Generic;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repositories
{
    public class TransferLogRepository : ITransferLogRepository
    {
        private readonly TransferDbContext _context;

        public TransferLogRepository(TransferDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            var transferLogs = _context.TransferLogs;
            return transferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            _context.TransferLogs.Add(transferLog);
            _context.SaveChanges();
        }
    }
}