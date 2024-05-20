namespace Restaurant_Management_System.Models.Repositories
{
    public interface ISeatingPreferenceRepository
    {
        Task<int> CreateSeatingPreferenceAsync(SeatingPreference seatingPreference);
        Task<int> UpdateSeatingPreferenceAsync(SeatingPreference seatingPreference);
        Task<int> DeleteSeatingPreferenceAsync(Guid Id);
        Task<IEnumerable<SeatingPreference>> GetSeatingPreferenceAsync();
        Task<int> DeleteSeatingPreference(Guid id);
    }
}
