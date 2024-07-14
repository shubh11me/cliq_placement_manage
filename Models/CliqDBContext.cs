using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliqlearn.Models
{
    public class CliqDBContext:DbContext
    {
        public CliqDBContext(DbContextOptions<CliqDBContext> options) : base(options)
        {
        }
    }
}
