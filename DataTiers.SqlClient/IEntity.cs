using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient {
    public interface IEntity {
        IEntityData EntityData { get; }
    }
}
