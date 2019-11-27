using PDE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDE.Repository
{
    public interface IMineRepository
    {
        Task<IEnumerable<MineDetails>> GetAllDetails ();
    }
}
