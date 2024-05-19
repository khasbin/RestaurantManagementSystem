namespace Restaurant_Management_System.Models.Repositories
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetAllReservationByIdAsync(int userId);
        Task<int> CreateReseravationAsync(int userId,Reservation reservation);
    }
}
