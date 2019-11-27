using MongoDB.Driver;
using PDE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PDE.Models.DataAccess;

namespace PDE.Repository
{

    public class MineRepository : IMineRepository
    {
        private readonly IMineContext _context;
        public MineRepository(IMineContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MineDetails>> GetAllDetails()
        {
            return await _context
                        .Mining
                        .Find(_ => true)
                        .ToListAsync();
        }
    }




}
