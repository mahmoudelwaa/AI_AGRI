namespace AgriAI.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? Phone { get; set; }
    public string? AvatarUrl { get; set; }
    public string? Governorate { get; set; }
    public bool IsVerified { get; set; }
    public ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
    public ICollection<Farm> Farms { get; set; } = new List<Farm>();
    public ICollection<UserCrop> UserCrops { get; set; } = new List<UserCrop>();
    
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}