
using Backend.DBContext;
using Backend.Models;
using Fluent.Infrastructure.FluentModel;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class ItemService
    {
        private readonly ApplicationDbContext _context;

        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task AddItemAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }
    }
}
