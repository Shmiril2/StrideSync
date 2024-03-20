using AutoMapper;
using StrideSync.Data.Entities;
using StrideSync.Data.Repositories.Abstractions;
using StrideSync.Service.Abstractions;
using StrideSync.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service
{
    public class ExerciseService:IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;
        public ExerciseService(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }
        public async Task AddExerciseAsync(ExerciseCreateEditDTO model)
        {
            var exercise = _mapper.Map<Exercise>(model);

            await _exerciseRepository.AddAsync(exercise);
        }

        public async Task DeleteExerciseByIdAsync(int id)
        {
            await _exerciseRepository.DeleteByIdAsync(id);
        }

        public async Task<ExerciseDTO> GetExerciseByIdAsync(int id)
        {
            var exercise = await _exerciseRepository
                .GetByIdAsync(id);
            return _mapper.Map<ExerciseDTO>(exercise);
        }

        public async Task<ExerciseCreateEditDTO> GetExerciseByIdEditAsync(int id)
        {
            var exercise = await _exerciseRepository
                .GetByIdAsync(id);
            return _mapper.Map<ExerciseCreateEditDTO>(exercise);
        }

        public async Task<List<ExerciseDTO>> GetExerciseByMuscleGroupAsync(string muscleGroup)
        {
            var exercises = await _exerciseRepository.GetAsync(item => item.MuscleGroup == muscleGroup);
            return _mapper.Map<List<ExerciseDTO>>(exercises);
        }

        public async Task<List<ExerciseDTO>> GetExercisesAsync()
        {
            var exercises = await _exerciseRepository.GetAllAsync();
            return _mapper.Map<List<ExerciseDTO>>(exercises);
        }

        public async Task UpdateExerciseAsync(ExerciseCreateEditDTO model)
        {
            var exercise = _mapper.Map<Exercise>(model);

            await _exerciseRepository.UpdateExercise(exercise);
        }
    }
}
