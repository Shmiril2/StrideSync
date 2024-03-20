using StrideSync.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories.Abstractions
{
    public interface ITrainingSessionRepository:ICrudRepository<TrainingSession>
    {
        public Task UpdateTrainingSession(TrainingSession trainingSession);
    }
}
