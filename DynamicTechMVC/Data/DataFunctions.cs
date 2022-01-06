using DynamicTechMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Data
{
    public class DataFunctions : IDataFunctions
    {
        private readonly ApplicationDbContext _context;

        public DataFunctions(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoriesToDelete, List<UserCategory> userCategoriesToAdd)
        {
            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.RemoveRange(userCategoriesToDelete);
                    await _context.SaveChangesAsync();
                    if (userCategoriesToAdd != null)
                    {
                        _context.AddRange(userCategoriesToAdd);
                        await _context.SaveChangesAsync();
                    }
                    await dbContextTransaction.CommitAsync();
                }
                catch (Exception Ex)
                {
                    await dbContextTransaction.DisposeAsync();
                }
            }
        }
    }
}
