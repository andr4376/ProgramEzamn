
namespace OOP_og_designpatterns
{
    /// <summary>
    /// Et interface som alle handlinger, actions, strategies skal have
    /// for at strategy klienten kan køre dens execute metode.
    /// 
    /// Kan bruges til at ændre objekters handlinger i runtime.
    /// f.eks kan man basere sit movement system på Strategy
    /// hvor hop, skyd, dø og andre funktionaliteter er strategies
    /// </summary>
    interface IStrategy
    {
        void Execute();
    }
}
