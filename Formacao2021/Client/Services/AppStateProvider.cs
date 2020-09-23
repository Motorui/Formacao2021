using Formacao2021.Shared.Models.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Formacao2021.Client.Services
{

    public class AppStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService api;
        private CurrentUser _currentUser;
        public AppStateProvider(IAuthService api)
        {
            this.api = api;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetCurrentUser();
                if (userInfo.IsAuthenticated)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, _currentUser.UserName) }.Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        #region User
        private async Task<CurrentUser> GetCurrentUser()
        {
            if (_currentUser != null && _currentUser.IsAuthenticated) return _currentUser;
            _currentUser = await api.CurrentUserInfo();
            return _currentUser;
        }
        public async Task Logout()
        {
            await api.Logout();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Login(LoginRequest loginParameters)
        {
            await api.Login(loginParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Register(RegisterUser registerParameters)
        {
            await api.Register(registerParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Update(RegisterUser registerParameters)
        {
            await api.Update(registerParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Delete(Guid id)
        {
            await api.Delete(id);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        #endregion
        #region Roles
        public async Task GetRoles()
        {
            await api.GetRoles();
        }
        public async Task GetUserRoles()
        {
            await api.GetUserRoles();
        }
        public async Task RegisterUserRoles(RegisterUserRole registerParameters)
        {
            await api.RegisterUserRoles(registerParameters);
            //NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task DeleteUserRoles(Guid id)
        {
            await api.DeleteUserRoles(id);
            //NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        #endregion
        #region UserUhs
        public async Task GetUserUhs()
        {
            await api.GetUserUhs();
        }
        public async Task RegisterUserUhs(RegisterUserUh registerParameters)
        {
            await api.RegisterUserUhs(registerParameters);
            //NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task DeleteUserUhs(Guid id)
        {
            await api.DeleteUserUhs(id);
            //NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        #endregion
    }
}
