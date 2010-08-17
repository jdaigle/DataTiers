namespace DataTiers.SqlClient {
    public interface IEntityData {
        EntityState EntityState { get; set; }
        bool SuppressEvents { get; set; }
    }
}
