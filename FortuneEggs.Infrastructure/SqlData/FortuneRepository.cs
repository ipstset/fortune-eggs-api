using FortuneEggs.Application;
using FortuneEggs.Application.Fortunes;

namespace FortuneEggs.Infrastructure.SqlData;

public class FortuneRepository : IFortuneRepository
{
    public async Task<Fortune> GetAsync(Guid id)
    {
        return new Fortune
        {
            Id = id,
            Message = "You are very gifted.",
            CreatedBy = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Random",
                LastName = "Person",
                Email = "rando@email.com"
            },
            DateCreated = DateTime.Now.AddDays(-30)
        };
    }
}