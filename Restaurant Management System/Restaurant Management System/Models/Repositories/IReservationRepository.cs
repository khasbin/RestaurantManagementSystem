namespace Restaurant_Management_System.Models.Repositories
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetAllReservationAsync(Guid userId, string userRole);
        Task<int> CreateReseravationAsync(Guid userId,Reservation reservation);
    }
}
