using MediatR;

namespace FortuneEggs.Application.Fortunes.GetFortune;

public class GetFortuneRequest : IRequest<Fortune?>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}