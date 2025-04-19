namespace FortuneEggs.Application.Fortunes;

public interface IFortuneRepository
{
    Task<Fortune> GetAsync(Guid id);
}