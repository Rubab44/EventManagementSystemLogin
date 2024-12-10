using Application.Extension.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;

namespace WebUI.Components.Layout.Identity
{
    internal static class SignOutEndpoint
    {
        public static RouteGroupBuilder MapSignOutEndpoint(this IEndpointRouteBuilder endpoints)
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var accountGroup = endpoints.MapGroup("/Account");

            accountGroup.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInManager) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.LocalRedirect("/Account/Login");
            });

            return accountGroup;
        }
    }
}
