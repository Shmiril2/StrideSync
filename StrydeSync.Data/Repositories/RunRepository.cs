using StrideSync.Data.Entities;
using StrideSync.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories
{
    public class RunRepository : CrudRepository<Run>, IRunRepository
    {
        private readonly ApplicationDbContext _context;
        public RunRepository(ApplicationDbContext context) 
            : base(context)
        {
            _context = context;
        }

        public async Task UpdateRun(Run run)
        {
            await UpdateAsync(run);
        }
    }
}
