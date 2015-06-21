using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;
using Mita.DataAccess.EF;

namespace ADTaskManager.DB
{

    [Export(typeof(IRepositoryProvider))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ADTaskManagerRepositoryProvider : EntityRepositoryProvider<Db>
    {
    }
}
