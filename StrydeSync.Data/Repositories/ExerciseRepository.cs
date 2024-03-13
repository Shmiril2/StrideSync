using StrideSync.Data.Entities;
using StrideSync.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories
{
    internal class ExerciseRepository : CrudRepository<Exercise>, IExerciseRepository
    {
        private readonly ApplicationDbContext _context;
        public ExerciseRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task UpdateExercise(Exercise exercise)
        {
            await UpdateAsync(exercise);
        }
    }
}
