using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADTaskManager.Model;

namespace ADTaskManager.DB
{
    public class Db : DbContext
    {
        public Db() : base("ADTaskManagerDb") { }

        public IDbSet<ADTask> Tasks { get; set; }
    }
}
