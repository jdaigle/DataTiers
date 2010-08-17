using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTiers.SqlClient {
    public abstract class EntityDataBase : IEntityData {

        protected EntityDataBase() {
            EntityState = EntityState.New;
        }

        public bool SuppressEvents { get; set; }

        public EntityState EntityState { get; private set; }

        public void AcceptChanges() {
            EntityState = EntityState.Unchanged;
        }

        protected void OnDataChanged() {
            if (SuppressEvents)
                return;
            if (EntityState == EntityState.Unchanged)
                EntityState = EntityState.Changed;
        }
    }
}
