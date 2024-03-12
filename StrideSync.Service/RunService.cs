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
    public class RunService : IRunService
    {
        private readonly IRunRepository _runRepository;
        private readonly IMapper _mapper;
        public RunService(IRunRepository runRepository, IMapper mapper)
        {
            _runRepository = runRepository;
            _mapper = mapper;
        }
        public async Task AddRunAsync(RunCreateEditDTO model)
        {
            var run = _mapper.Map<Run>(model);

            await _runRepository.AddAsync(run);
        }

        public async Task DeleteRunByIdAsync(int id)
        {
            await _runRepository.DeleteByIdAsync(id);
        }

        public async Task<RunDTO> GetRunByIdAsync(int id)
        {
            var run = await _runRepository
                .GetByIdAsync(id);
            return _mapper.Map<RunDTO>(run);
        }

        public async Task<RunCreateEditDTO> GetRunByIdEditAsync(int id)
        {
            var run = await _runRepository
                .GetByIdAsync(id);
            return _mapper.Map<RunCreateEditDTO>(run);
        }

        public async Task<List<RunDTO>> GetRunByDistanceAsync(int distance)
        {
            var runs = await _runRepository.GetAsync(item => item.Distance == distance);
            return _mapper.Map<List<RunDTO>>(runs);
        }

        public async Task<List<RunDTO>> GetRunsAsync()
        {
            var runs = await _runRepository.GetAllAsync();
            return _mapper.Map<List<RunDTO>>(runs);
        }

        public async Task UpdateRunAsync(RunCreateEditDTO model)
        {
            var run = _mapper.Map<Run>(model);

            await _runRepository.UpdateRun(run);
        }
    }
}
