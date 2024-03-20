using StrideSync.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.Abstractions
{
    public interface IExerciseService
    {
        Task<List<ExerciseDTO>> GetExercisesAsync();
        Task<ExerciseDTO> GetExerciseByIdAsync(int id);
        Task<ExerciseCreateEditDTO> GetExerciseByIdEditAsync(int id);
        Task<List<ExerciseDTO>> GetExerciseByMuscleGroupAsync(string muscleGroup);
        Task AddExerciseAsync(ExerciseCreateEditDTO model);
        Task DeleteExerciseByIdAsync(int id);
        Task UpdateExerciseAsync(ExerciseCreateEditDTO model);
    }
}
