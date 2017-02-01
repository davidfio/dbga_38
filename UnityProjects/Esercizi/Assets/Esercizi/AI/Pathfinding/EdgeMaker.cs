using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AI.Pathfinding
{
    public class VisualEdge
    {
        public VisualNode nodeFrom;
        public VisualNode nodeTo;
        public Color color;

        public override bool Equals(object obj)
        {
            VisualEdge otherEdge = (VisualEdge)obj;
            return this.nodeFrom == otherEdge.nodeFrom && this.nodeTo == otherEdge.nodeTo;
        }
    }
    public class EdgeMaker : MonoBehaviour
    {
           
        public Queue<VisualNode> queue = new Queue<VisualNode>();

        public List<VisualEdge> visualEdges = new List<VisualEdge>();

        public void Awake()
        {
            var allVisualNodes = FindObjectsOfType<VisualNode>();

            foreach (var node in allVisualNodes)
            {
                if (node.isStartNode)
                {
                    queue.Enqueue(node);
                }
            }

            foreach (var nodeFrom in allVisualNodes)
            {
                foreach (var nodeTo in allVisualNodes)
                {
                    float distance = (nodeTo.transform.position - nodeFrom.transform.position).magnitude;

                    VisualEdge oppositeEdge = new VisualEdge();
                    oppositeEdge.nodeFrom = nodeTo;
                    oppositeEdge.nodeTo = nodeFrom;
                    oppositeEdge.color = Color.white;

                    //if (nodeFrom == nodeTo) continue;  // Not the same node and only if close enough

                    if (nodeFrom != nodeTo && distance < 3f && !visualEdges.Contains(oppositeEdge))
                    {
                        // Create the edge
                        VisualEdge edge = new VisualEdge();
                        edge.nodeFrom = nodeFrom;
                        edge.nodeTo = nodeTo;
                        edge.color = Color.white;
                        visualEdges.Add(edge);
                    }

                }
            }

            Debug.Log(visualEdges.Count);
            Debug.Log(queue.Count);
        }
    }
}