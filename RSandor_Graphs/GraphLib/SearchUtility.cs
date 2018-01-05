﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLib
{
    public static class SearchUtility<T> where T : struct, IComparable<T>
    {
        // TODO: implement Dijkstra Search
        public static List<Edge<T>> DijkstraSearch(Vertex<T> start, Vertex<T> end)
        {

            return null;
        }

        // TODO: revise function signature - what should it return? a list or queue?
        public static List<Vertex<T>> BFS(Graph<T> graph, Vertex<T> start)
        {
            // I should probably ensure that the entire list isn't visited
            for(int index = 0; index < graph.Vertices.Count; index++)
            {
                graph.Vertices[index].Visited = false;
            }

            // do I need a queue here or a list? most likely queue
            Queue<Vertex<T>> nodesToVisit = new Queue<Vertex<T>>();
            List<Vertex<T>> traversedPath = new List<Vertex<T>>();
            int indexOfStart = graph.Vertices.FindIndex(vertex => vertex.Value.Equals(start.Value));
            graph.Vertices[indexOfStart].Visited = true;

            nodesToVisit.Enqueue(graph.Vertices[indexOfStart]);

            while(nodesToVisit.Count > 0)
            {
                Vertex<T> visitedNode = nodesToVisit.Dequeue();
                // find the visitedNode's neighbors
                // look through the edge list where that vertex is the start vertex

                traversedPath.Add(visitedNode);

                // perhaps I can make a function out of this?
                List<Vertex<T>> neighbors = new List<Vertex<T>>();
                // find the neighbors
                // go through each edge to find neighbors
                foreach(var edge in graph.Edges)
                {
                    // if the start of the edge matches the visited node,
                    // then we've found an outgoing edge (neighbor)
                    if(edge.Start.Value.Equals(visitedNode.Value))
                    {
                        neighbors.Add(edge.End);
                        continue;
                    }
                }

                foreach(var neighbor in neighbors)
                {
                    if(neighbor.Visited)
                    {
                        continue;
                    }

                    neighbor.Visited = true;
                    nodesToVisit.Enqueue(neighbor);
                }
            }

            return traversedPath;
        }

        // TODO: revise function signature
        public static List<T> DFS(Graph<T> graph, Vertex<T> start)
        {
            for (int index = 0; index < graph.Vertices.Count; index++)
            {
                graph.Vertices[index].Visited = false;
            }

            return null;
        }
    }
}
