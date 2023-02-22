namespace DP.Core.Structural_Patterns.Facade.Exemplo_1.Clients
{
    public class PayPalGateway : IPayPalGateway
    {
        public bool CommitTransaction(string cardHasKey, Guid orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public string GetCardHashKey(string serviceKey, string creditCard)
        {
            return new string(Enumerable.Repeat(serviceKey + creditCard, 5)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat(apiKey + encriptionKey, 5)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
