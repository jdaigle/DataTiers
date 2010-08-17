namespace DataTiers.SqlClient {
    public interface IEntityData {
        EntityState EntityState { get; }
        bool SuppressEvents { get; set; }
        void AcceptChanges();
    }
}
