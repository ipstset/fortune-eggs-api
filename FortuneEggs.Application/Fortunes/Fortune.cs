namespace FortuneEggs.Application.Fortunes;

public class Fortune
{
    public Guid Id { get; set; }
    public string Message { get; set; }
    public User CreatedBy { get; set; }
    public DateTime DateCreated { get; set; }
}