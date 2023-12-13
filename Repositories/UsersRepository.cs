using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class UsersRepository : IUserRepository
    {
        private readonly MyDbContext _context;

        public UsersRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(Users user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public List<Users> GetAllUsers()
        {
            var UsersList = _context.Users.ToList();
            return UsersList;
        }

        public Users GetUserByEmailAndPassword(LoginUserRequest loginUser)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == loginUser.Email && u.Password == loginUser.Password);
            return user;
        }

        public Users GetUserById(int id)
        {
            var User = _context.Users.Find(id);
            return User;
        }

        public void UpdateUser(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
