using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient {
    public abstract class EntityDataBase : IEntityData {
        
        public bool SuppressEvents { get; set; }
        
        public EntityState EntityState { get; set; }

        protected void OnDataChanged() {
            if (SuppressEvents)
                return;
            if (EntityState == EntityState.Unchanged)
                EntityState = EntityState.Changed;
        }
    }
}
