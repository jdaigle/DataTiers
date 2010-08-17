using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient {
    public enum EntityState {
        Unchanged = 0,
        New = 1,
        Changed = 2,
    }
}
