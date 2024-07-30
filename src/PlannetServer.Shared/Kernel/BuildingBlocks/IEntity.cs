namespace PlannetServer.Shared.Kernel.BuildingBlocks
{
    public interface IEntity<TEntityId, T>
        where TEntityId : TypedIdValueBase<T>
        where T : IEquatable<T>
    {
        TEntityId Id { get; }
    }


}
