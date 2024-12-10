using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTO.Response;
//using Application.DTO.Response.ActivityTracker;
using Application.DTO.Response.Identity;
//using Application.DTO.Request.ActivityTracker;
using Application.DTO.Request.Identity;

using System.Threading.Tasks;

namespace Application.Service
{
    public interface IAccountService
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();
        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        //Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        //Task<IEnumerable<ActivityTrackerResponsetDTO>> GetActivitiesAsync();
    }
}
