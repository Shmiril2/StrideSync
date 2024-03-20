using StrideSync.Data.Entities;
using StrideSync.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories
{
    public class TrainingSessionRepository : CrudRepository<TrainingSession>, ITrainingSessionRepository
    {
        private readonly ApplicationDbContext _context;
        public TrainingSessionRepository(ApplicationDbContext context) : base(context)
        {
            _context=context;
        }

        public async Task UpdateTrainingSession(TrainingSession trainingSession)
        {
            await UpdateAsync(trainingSession);
        }
    }
}
