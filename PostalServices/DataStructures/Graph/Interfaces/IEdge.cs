using System;

namespace PostalServices.DataStructures.Graph.Interfaces
{
    public interface IEdge : IComparable<IEdge>, IEquatable<IEdge>
    {
        IVertex V { get; }
        IVertex U { get; }
        int Weight { get; }
    }
}
