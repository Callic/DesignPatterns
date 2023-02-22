namespace DP.Core.Structural_Patterns.Facade.Exemplo_1.Clients
{
    /// <summary>
    /// A interface está em inglês justamente para simular um facade, utilizando a nomenclatura dos métodos e parâmetros assim como descritos na documentação de terceiros
    /// </summary>
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHasKey, Guid orderId, decimal amount);
        string GetCardHashKey(string serviceKey, string creditCard);
        string GetPayPalServiceKey(string apiKey, string encriptionKey);

    }
}
