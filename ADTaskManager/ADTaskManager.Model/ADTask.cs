using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADTaskManager.Model
{
    public class ADTask : TitledDomainObject
    {
        public string Description { get; set; }
        public string Performers { get; set; }
        public int Status { get; set; }
        public int PlannedLabor { get; set; }
        public int ActualLabor { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public ICollection<ADTask> ChildTasks { get; set; }
        public int ParentId { get; set; }
    }
}
