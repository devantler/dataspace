namespace Devantler.DataMesh.DataProduct.DataStore.Relational.Entities;

/// <summary>
/// An interface for entities.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// A unique identifier for the entity.
    /// </summary>
    public Guid Id { get; set; }
}