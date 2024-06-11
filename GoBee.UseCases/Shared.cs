namespace GoBee.UseCases;

public interface IUseCase<TInput, TOutput>
{
    public Task<TOutput> Executar(TInput input);
}
