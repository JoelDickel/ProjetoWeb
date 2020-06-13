using ProjetoWeb.Data;
using ProjetoWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWeb.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebContext _context;

        public DepartmentService(ProjetoWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
