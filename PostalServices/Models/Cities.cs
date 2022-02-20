using System.Linq;
using PostalServices.Algorithms;
using PostalServices.DataStructures;
using PostalServices.DataStructures.Graph;

namespace PostalServices.Models
{
    public class Cities
    {
        public static Graph GetGraph()
        {
            var graph = new Graph(verticesCount: 12);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            graph.AddEdge(numV: 0, numU: 1, weight: 7);
            graph.AddEdge(numV:0, numU: 1, weight: 7);
            return graph;
        }

        public void SearchCitiesTest()
        {
            var graph = GetGraph();
            // aqui vai a logica de pegar os vertices e jogar no algorimos Dijkstra
            var vertex0 = graph[0];
            var vertex1 = graph[1];
            var vertex2 = graph[2];
            var vertex3 = graph[3];
            var vertex4 = graph[4];
            var vertex5 = graph[5];
            var vertex6 = graph[6];
            var vertex7 = graph[7];
            var vertex8 = graph[8];
            var vertex9 = graph[9];
            var vertex10 = graph[10];
            var vertex11 = graph[11];

            var distances = Dijkstra.Search(graph, vertex0);
            // aqui pode-se criar uma nova var que faria a validação do Dijktra se ela retornar negativo  retorna "distance not found correctly"
            
            var isValid = distances.FirstOrDefault(d => d.Vertex.Equals(vertex0)).Value == 0;
            isValid &= distances.FirstOrDefault(d => d.Vertex.Equals(vertex1)).Value == 7;
            isValid &= distances.FirstOrDefault(d => d.Vertex.Equals(vertex2)).Value == 9;
            isValid &= distances.FirstOrDefault(d => d.Vertex.Equals(vertex3)).Value == 20;
            isValid &= distances.FirstOrDefault(d => d.Vertex.Equals(vertex4)).Value == 20;
            isValid &= distances.FirstOrDefault(d => d.Vertex.Equals(vertex5)).Value == 11;
            

            
        }
    }
}
