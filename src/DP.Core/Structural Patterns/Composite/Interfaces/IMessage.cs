namespace DP.Core.Structural_Patterns.Composite.Interfaces
{
    public interface IMessage
    {
        string Nome { get; }
        void ExibirMensagens(int prefix);
    }
}
