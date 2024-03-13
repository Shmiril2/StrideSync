using Microsoft.EntityFrameworkCore.Update.Internal;
using StrideSync.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories.Abstractions
{
    public interface IExerciseRepository : ICrudRepository<Exercise>
    {
        public Task UpdateExercise(Exercise exercise);
    }
}
