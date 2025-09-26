using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            //seller.Department = new Department(5, "Food");
            //seller.Department = _context.Department.First();
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (hasAny)
            {
                try
                {
                    _context.Update(obj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    throw new Services.Exceptions.DbConcurrencyException(e.Message);
                }
            }
            else
            {
                throw new Services.Exceptions.NotFoundException("Id not found");
            }
        }
    }
}
