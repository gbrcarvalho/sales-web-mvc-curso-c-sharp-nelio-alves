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

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Insert(Seller seller)
        {
            //seller.Department = new Department(5, "Food");
            //seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
        public void Update(Seller obj)
        {
            if (_context.Seller.Any(x => x.Id == obj.Id))
            {
                try
                {
                    _context.Update(obj);
                    _context.SaveChanges();
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
