
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
        public async Task<int> CreateReseravationAsync(int userId, Reservation reservation)
        {
            if (userId != null)
            {
                await _dbcontext.Reservations.AddAsync(reservation);
                return await _dbcontext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("The user doesn't exists. ");
            }
            
        }

        public Task<IEnumerable<Reservation>> GetAllReservationByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
