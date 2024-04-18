// using Microsoft.EntityFrameworkCore;
// using Server.Context.Abstract;
// using Server.Context.Context;
// using Server.Model.Models;
//
// namespace Server.Context.Repositories;
//
// public class UserRepository : IUserRepository
// {
//     private readonly ApplicationDbContext _context;
//
//     public UserRepository(ApplicationDbContext context)
//     {
//         _context = context;
//     }
//
//     public async Task<User?> GetUserByIdAsync(int id)
//     {
//         return await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
//     }
//     
//     public async Task<User> GetUserByEmailAsync(string email)
//     {
//         if (email == null) throw new ArgumentNullException(nameof(email));
//
//         return await _context.Users.FirstOrDefaultAsync(u => u.Email == email) ?? throw new InvalidOperationException();
//     }
//
//     public async Task<List<User>> GetUsersAsync()
//     {
//         return await _context.Users.ToListAsync();
//     }
//
//     public async Task<User> AddAsync(User user)
//     {
//         _context.Users.Add(user);
//         await _context.SaveChangesAsync();
//         return user;
//     }
//
//     public async Task<bool> UpdateAsync(User user)
//     {
//         _context.Update(user);
//         return await Save();
//     }
//
//     public async Task DeleteAsync(int id)
//     {
//         var user = await _context.Users.FindAsync(id);
//         
//         if (user != null)
//         {
//             // var meetingsToDelete = _context.Meetings.Where(m => m.UserId == id);
//             // _context.Meetings.RemoveRange(meetingsToDelete);
//             _context.Users.Remove(user);
//             await _context.SaveChangesAsync();
//         }
//     }
//
//     public bool UserExists(int userId)
//     {
//         // return _context.Users.Any(u => u.Id == userId);
//         return true;
//     }
//     
//     public async Task<bool> Save()
//     {
//         var saved = await _context.SaveChangesAsync();
//
//         return saved > 0;
//     }
// }