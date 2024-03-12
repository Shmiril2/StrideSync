using StrideSync.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.Abstractions
{
    public interface IRunService
    {
        Task<List<RunDTO>> GetRunsAsync();
        Task<RunDTO> GetRunByIdAsync(int id);
        Task<RunCreateEditDTO> GetRunByIdEditAsync(int id);
        Task<List<RunDTO>> GetRunByDistanceAsync(int distance);
        Task AddRunAsync(RunCreateEditDTO model);
        Task DeleteRunByIdAsync(int id);
        Task UpdateRunAsync(RunCreateEditDTO model);
    }
}
