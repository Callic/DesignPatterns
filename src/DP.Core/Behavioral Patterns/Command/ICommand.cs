
namespace DP.Core.Behavioral_Patterns.Command
{
    public interface ICommand
    {
        void Executar();
        void Desfazer();
    }
}
