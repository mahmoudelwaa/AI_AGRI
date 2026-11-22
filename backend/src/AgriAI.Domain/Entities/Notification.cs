namespace AgriAI.Domain.Entities;

public class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Type { get; set; } = "General";

    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string BodyAr { get; set; } = default!;
    public string BodyEn { get; set; } = default!;

    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User User { get; set; } = default!;
}