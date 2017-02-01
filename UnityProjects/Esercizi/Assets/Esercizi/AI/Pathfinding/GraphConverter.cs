using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace AI.Pathfinding
{

    // Data structure
    public class Node
    {

    }

    public class Edge
    {
        public Node nodeFrom;
        public Node nodeTo;
    }

    public class AlgorithmData
    {
        public List<Node> allNode;
        public List<Edge> allEdge;
        public Node startNode;
        public Node endNode;
    }


    public class GraphConverter : MonoBehaviour
    {
        // Dictionaries that define the mapping Visul-to-Logic
        Dictionary<VisualNode, Node> visualNodeToNodeDict = new Dictionary<VisualNode, Node>();
        Dictionary<Node, VisualNode> nodeToVisualNodeDict = new Dictionary<Node, VisualNode>();

        Dictionary<VisualEdge, Edge> visualEdgeToEdgeDict = new Dictionary<VisualEdge, Edge>();
        Dictionary<Edge, VisualEdge> edgeToVisualDict = new Dictionary<Edge, VisualEdge>();

        public AlgorithmData currentData;

        public void Awake()
        {
            

            // ....perform the algorithm
        }

        

        

        #region Conversion

        public AlgorithmData ConvertVisualsToData()
        {
            AlgorithmData data = new AlgorithmData();

            var visualNodes = FindObjectsOfType<VisualNode>();

            data.allNode = new List<Node>();

            foreach (var visualNode in visualNodes)
            {
                Node newNode = new Node();
                data.allNode.Add(newNode);

                if (visualNode.isStartNode)
                {
                    data.startNode = newNode;
                }

                if (visualNode.isEndNode)
                {
                    data.endNode = newNode;
                }

                visualNodeToNodeDict[visualNode] = newNode;
                nodeToVisualNodeDict[newNode] = visualNode;
            }

            var visualEdges = FindObjectOfType<EdgeMaker>().visualEdges;
            data.allEdge = new List<Edge>();
            foreach (var visualEdge in visualEdges)
            {
                Edge newEdge = new Edge();
                data.allEdge.Add(newEdge);

                visualEdgeToEdgeDict[visualEdge] = newEdge;
                edgeToVisualDict[newEdge] = visualEdge;

                newEdge.nodeFrom = visualNodeToNodeDict[visualEdge.nodeFrom];
                newEdge.nodeTo = visualNodeToNodeDict[visualEdge.nodeTo];
            }

            return data;
        }

        #endregion

        #region Visualization

        public void SelectNode(Node node)
        {
            VisualNode visualNode = nodeToVisualNodeDict[node];
            visualNode.GetComponent<SpriteRenderer>().color = Color.red;
        }

        public void UnselectNode(Node node)
        {
            VisualNode visualNode = nodeToVisualNodeDict[node];
            visualNode.GetComponent<SpriteRenderer>().color = Color.white;
        }

        public void SelectEdge(Edge edge)
        {
            VisualEdge visualeEdge = edgeToVisualDict[edge];
            visualeEdge.color = Color.red;
        }

        public void UnselectEdge(Edge edge)
        {
            VisualEdge visualeEdge = edgeToVisualDict[edge];
            visualeEdge.color = Color.white;
        }


        public void Update()
        {
            foreach (var edge in currentData.allEdge)
            {
                VisualEdge visualeEdge = edgeToVisualDict[edge];
                Debug.DrawLine(visualeEdge.nodeFrom.transform.position, visualeEdge.nodeTo.transform.position, visualeEdge.color);
            }
        }

        #endregion
    }

}