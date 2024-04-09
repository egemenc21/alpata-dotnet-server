namespace Server.Model.Models;

public class BaseModel
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    protected BaseModel()
    {
        CreatedAt = DateTime.UtcNow;
    }
    
}