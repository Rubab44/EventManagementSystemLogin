
using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;
using Application.Interface.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Service
{
    public class AccountService(IAccount account) : IAccountService
    {
        public async Task <ServiceResponse> CreateUserAsync(CreateUserRequestDTO requestDTO)
            => await account.CreateUserAsync(requestDTO);

        public async Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync()
    =>      await account.GetUsersWithClaimsAsync();
        public async Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model)
            => await account.LoginAsync(model);


        public async Task SetUpAsync() => await account.SetUpAsync();
        public Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model)
            => account.UpdateUserAsync(model);

      
    }
}
