using MediatR;

namespace FortuneEggs.Application.Fortunes.GetFortune;

public class GetFortuneHandler(IFortuneRepository repository) : IRequestHandler<GetFortuneRequest, Fortune?>
{
    private readonly IFortuneRepository _fortuneRepository = repository;
    public async Task<Fortune?> Handle(GetFortuneRequest request, CancellationToken cancellationToken)
    {
        //todo: check user permission
        
        var fortune = await _fortuneRepository.GetAsync(request.Id);
        //todo: fortune is null

        //want to use result??
        return fortune;
    }
}