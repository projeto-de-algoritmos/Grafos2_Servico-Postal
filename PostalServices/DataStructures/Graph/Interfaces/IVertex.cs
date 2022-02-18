using System;
using System.Collections.Generic;

namespace PostalServices.DataStructures.Graph.Interfaces
{
    public interface IVertex : IEquatable<IVertex>
    {
        IReadOnlyCollection<IEdge> Edges { get; }
        int Num { get; }
        void AddEdge(IEdge edge);
        bool TryGetEdge(IVertex vertex, out IEdge edge);
    }
}
