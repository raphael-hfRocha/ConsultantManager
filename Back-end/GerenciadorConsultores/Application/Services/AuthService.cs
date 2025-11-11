using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthRepository _authRepository;

        public AuthService(HttpClient httpClient, AuthRepository authRepository)
        {
            _httpClient = httpClient;
            _authRepository = authRepository;
        }
    }
}
