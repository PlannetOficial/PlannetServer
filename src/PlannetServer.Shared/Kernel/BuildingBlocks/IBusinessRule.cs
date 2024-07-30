namespace PlannetServer.Shared.Kernel.BuildingBlocks
{
    public interface IBusinessRule
    {
        string Message { get; }
        bool IsBroken();
    }
}
