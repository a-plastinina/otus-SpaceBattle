using System.Threading.Tasks;


namespace SpaceBattle.App.Interface;

public interface ICommandAsync
{
    Task Execute();
}