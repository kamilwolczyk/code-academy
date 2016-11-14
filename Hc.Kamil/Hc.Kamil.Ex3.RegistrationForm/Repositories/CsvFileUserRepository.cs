using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Hc.Kamil.Ex3.RegistrationForm.Models;
using Hc.Kamil.Ex3.RegistrationForm.Security;

namespace Hc.Kamil.Ex3.RegistrationForm.Repositories
{
    public class CsvFileUserRepository : IUserRepository
    {
        public const char CsvSeparator = ',';

        private readonly string _fileName;

        private readonly IHashProvider _hashProvider;

        private IList<User> _users;

        public CsvFileUserRepository(string fileName, IHashProvider hashProvider)
        {
            _fileName = fileName;
            _hashProvider = hashProvider;
        }

        private IList<User> Users
        {
            get { return _users ?? (_users = ReadUsersFromFile()); }
        }

        public User GetUser(string login, string password)
        {
            var hash = _hashProvider.GetHash(password);
            return Users.FirstOrDefault(user => user.Login == login && user.Password == hash);
        }

        public bool ExistUser(string login)
        {
            return Users.Any(user => user.Login == login);
        }

        public void AddUser(User user)
        {
            if (ExistUser(user.Login))
                throw new InvalidOperationException($"User with login {user.Login} currently exists.");

            user.Password = _hashProvider.GetHash(user.Password);

            Users.Add(user);
            WriteUserToEndOfFile(user);
        }

        private void EnsureFileExists()
        {
            if (File.Exists(_fileName))
                return;

            var file = File.Create(_fileName);
            file.Dispose();
        }

        private IList<User> ReadUsersFromFile()
        {
            EnsureFileExists();
            return File.ReadAllLines(_fileName)
                       .Select(line =>
                       {
                           var parts = line.Split(CsvSeparator);
                           return parts.Count() == 2 ? new User(parts[0], parts[1]) : null;
                       })
                       .Where(item => item != null)
                       .ToList();
        }

        private void WriteUserToEndOfFile(User user)
        {
            EnsureFileExists();
            using (var file = File.AppendText(_fileName))
                file.WriteLine($"{user.Login}{CsvSeparator}{user.Password}");
        }
    }
}