using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.DAL.Context
{
    public class DataContext: DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
    }
}
