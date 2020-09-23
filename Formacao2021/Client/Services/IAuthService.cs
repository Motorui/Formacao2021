using Formacao2021.Shared.Models.Identity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Formacao2021.Client.Services
{
    public interface IAuthService
    {
        #region User
        Task<CurrentUser> CurrentUserInfo();
        Task Login(LoginRequest loginRequest);
        Task Logout();
        Task Register(RegisterUser registerUser);
        Task Update(RegisterUser registerUser);
        Task Delete(Guid id);
        #endregion
        #region Roles
        Task<IList<RegisterRoles>> GetRoles();
        Task<IList<RegisterUserRole>> GetUserRoles();
        Task RegisterUserRoles(RegisterUserRole userRole);
        Task DeleteUserRoles(Guid id);
        #endregion
        #region UserUhs
        Task<IList<RegisterUserUh>> GetUserUhs();
        Task RegisterUserUhs(RegisterUserUh userUh);
        Task DeleteUserUhs(Guid id);
        #endregion
    }

    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region User
        public async Task<CurrentUser> CurrentUserInfo()
        {
            var result = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
            return result;
        }

        public async Task Login(LoginRequest loginRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/auth/logout", null);
            result.EnsureSuccessStatusCode();
        }

        public async Task Register(RegisterUser registerUser)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", registerUser);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Update(RegisterUser registerUser)
        {
            var result = await _httpClient.PutAsJsonAsync("api/auth/update", registerUser);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Delete(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/auth/delete/{id}");
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
        #endregion
        #region Roles
        public async Task<IList<RegisterRoles>> GetRoles()
        {
            var result = await _httpClient.GetFromJsonAsync<RegisterRoles[]>("api/auth/getroles");
            return result;
        }
        public async Task<IList<RegisterUserRole>> GetUserRoles()
        {
            var result = await _httpClient.GetFromJsonAsync<RegisterUserRole[]>("api/auth/getuserroles");
            return result;
        }
        public async Task RegisterUserRoles(RegisterUserRole userRole)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/registeruserroles", userRole);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
        public async Task DeleteUserRoles(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/auth/deleteuserroles/{id}");
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
        #endregion
        #region UserUhs
        public async Task<IList<RegisterUserUh>> GetUserUhs()
        {
            var result = await _httpClient.GetFromJsonAsync<RegisterUserUh[]>("api/auth/getuseruhs");
            return result;
        }
        public async Task RegisterUserUhs(RegisterUserUh userUh)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/registeruseruhs", userUh);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }
        public async Task DeleteUserUhs(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/auth/deleteuseruhs/{id}");
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        #endregion
    }
}
