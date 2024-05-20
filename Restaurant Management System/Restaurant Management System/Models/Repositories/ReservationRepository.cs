using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Restaurant_Management_System.Models.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private RestaurantManagementSystemDbContext _dbcontext;
        public ReservationRepository(RestaurantManagementSystemDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> CreateReseravationAsync(Guid userId, Reservation reservation)
        {
            var pulledUser = await _dbcontext.Reservations.FirstOrDefaultAsync(r => r.Id == userId);
            if (userId != null && pulledUser != null)
            {
                await _dbcontext.Reservations.AddAsync(reservation);
                return await _dbcontext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("The user doesn't exists. ");
            } 
        }

        public async Task<IEnumerable<Reservation>> GetAllReservationAsync(Guid userId, string userRole)
        {
            IQueryable<Reservation> query = _dbcontext.Reservations;
            if(userRole == "Staff" || userRole =="Admin")
            {
                //query = query.Include(r => r.ReservationHistories);
            }
            else
            {
                query = query.Where(r => r.Id == userId);
            }
            return await query.ToListAsync();
        }
    }
}
