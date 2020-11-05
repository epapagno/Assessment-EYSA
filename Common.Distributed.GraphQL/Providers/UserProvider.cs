using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using Common.Infr.Support.Security;

namespace Common.Distributed.GraphQL.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IHttpContextAccessor context;
        public UserProvider(IHttpContextAccessor context)
        {
            this.context = context;
        }
        public string UserName => context.HttpContext.User.FindFirst(JwtRegisteredClaimNames.Sub).Value.ToUpper();
    }
}
