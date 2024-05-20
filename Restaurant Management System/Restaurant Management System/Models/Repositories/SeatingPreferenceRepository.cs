using Restaurant_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Restaurant_Management_System.Models.Repositories
{
    public class SeatingPreferenceRepository : ISeatingPreferenceRepository
    {
        private readonly RestaurantManagementSystemDbContext _dbcontext;

        public SeatingPreferenceRepository(RestaurantManagementSystemDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> CreateSeatingPreferenceAsync(SeatingPreference seatingPreference)
        {
            if(seatingPreference  != null)
            {
                await _dbcontext.AddAsync(seatingPreference);
                return await _dbcontext.SaveChangesAsync();
            }
            throw new Exception("The seating preference you added is not valid");
        }

        public async Task<int> DeleteSeatingPreference(Guid id)
        {
            var preferencetoDelete = await _dbcontext.SeatingPreferences.FirstOrDefaultAsync(s => s.SeatingPreferenceId == id);
            
            if(preferencetoDelete != null)
            {
                _dbcontext.SeatingPreferences.Remove(preferencetoDelete);
                int result = await _dbcontext.SaveChangesAsync();
                return result;
            }
            throw new Exception("The required Seating Preference cannot be found ");
        }

        public async Task<int> DeleteSeatingPreferenceAsync(Guid Id)
        {
            var seatingPrefereceToDelete = _dbcontext.SeatingPreferences.FirstOrDefaultAsync(x => x.SeatingPreferenceId == Id);
            if(seatingPrefereceToDelete != null)
            {
                _dbcontext.Remove(seatingPrefereceToDelete);
                return await _dbcontext.SaveChangesAsync();
            }
            throw new Exception("The seating preference you want to delete is not valid");
        }

        public async Task<IEnumerable<SeatingPreference>> GetSeatingPreferenceAsync()
        {
            List<SeatingPreference> allPreferences;
            allPreferences = await _dbcontext.SeatingPreferences.AsNoTracking().OrderBy(c => c.SeatingPreferenceId).ToListAsync();
            return allPreferences;
        }

        public async Task<int> UpdateSeatingPreferenceAsync(SeatingPreference seatingPreference)
        {
            var seatingPreferenceToUpdate = await _dbcontext.SeatingPreferences.FirstOrDefaultAsync(s => s.SeatingPreferenceId == seatingPreference.SeatingPreferenceId);
            if(seatingPreferenceToUpdate != null)
            {
                seatingPreferenceToUpdate.PreferenceDetails = seatingPreference.PreferenceDetails;
                _dbcontext.SeatingPreferences.Update(seatingPreferenceToUpdate);
                return  await _dbcontext.SaveChangesAsync();
            }
            throw new Exception("The seating preference to update doesn't exists.");
        }
    }
}
