using System;
using System.Collections.Generic;

namespace PathFinder
{
    public class Graph<T>
    {

        /// <summary>
        /// Contains the nodes of the graph.
        /// </summary>

        protected List<T> nodes;

        /// <summary>
        /// Contains the node connections of the graph.
        /// </summary>

        protected List<ValueTuple<int, int>> connections;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PathFinder.Graph"/>
        /// class.
        /// </summary>

        public Graph()
        {
            nodes = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PathFinder.Graph`1"/>
        ///  class.
        /// </summary>
        /// <param name="nodes">Nodes.</param>

        public Graph(List<T> nodes)
        {
            this.nodes = nodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PathFinder.Graph`1"/>
        /// class.
        /// </summary>
        /// <param name="nodes">Nodes.</param>
        /// <param name="connections">Connections.</param>
        public Graph(List<T> nodes, List<ValueTuple<int, int>> connections)
        {
            this.nodes = nodes;
            this.connections = connections;
        }

        /// <summary>
        /// Adds a single node to the graph.
        /// </summary>
        /// <param name="node">Node.</param>
        public bool AddNode(T node)
        {
            if (!this.nodes.Contains(node))
            {
                this.nodes.Add(node);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds the nodes to the graph and returns how many was actually added.
        /// </summary>
        /// <returns>The nodes.</returns>
        /// <param name="nodes">Nodes.</param>
        public int AddNodes(List<T> nodes)
        {
            int count = 0;
            foreach (T i in nodes)
            {
                if (!this.nodes.Contains(i))
                {
                    this.nodes.Add(i);
                    ++count;
                }
            }
            return count;
        }

        /// <summary>
        /// Finds and retruns one of the shortest paths between the specified
        /// nodes.
        /// </summary>
        /// <returns>The path.</returns>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public List<T> FindPath(T from, T to)
        {
            List<T> path = new List<T>();

            return path;
        }

    }
}
