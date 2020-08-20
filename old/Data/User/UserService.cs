using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DotsAndBoxes.Data.User
{
    public class UserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly List<User> _users = new List<User>();

        public UserService(ILogger<UserService> logger) { _logger = logger; }
        public User CurrentUser { get; private set; }

        public Task<User[]> GetAllUsersAsync() { return Task.FromResult(_users.ToArray()); }

        public Task<User> CreateUser(string username)
        {
            CurrentUser = new User(username);
            while (CurrentUser.Id == Guid.Empty || IsPresent(CurrentUser.Id)) CurrentUser.Id = Guid.NewGuid();
            _users.Add(CurrentUser);
            _logger.LogInformation($"Created User \t{{ ID: {CurrentUser.Id}  |  UserName: {CurrentUser.UserName} }}");
            return Task.FromResult(CurrentUser);
        }

        public bool IsPresent(Guid id) { return _users.Any(u => u.Id == id); }
    }
}