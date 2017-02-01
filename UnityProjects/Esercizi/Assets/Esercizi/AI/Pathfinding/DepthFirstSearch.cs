using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace AI.Pathfinding
{
    public class DepthFirstSearch : Algorithm
    {      

        protected override IEnumerator PerformAlgorithmCO(AlgorithmData data)
        {
            bool result = false;

            Stack<Node> stack = new Stack<Node>();
            List<Node> visitedNodes = new List<Node>();
            stack.Push(data.startNode);
            visitedNodes.Add(data.startNode);
            while (stack.Peek() != null)
            {
                Node current = stack.Pop();
                visitedNodes.Add(current);

                converter.SelectNode(current);
                yield return new WaitForSeconds(0.2f);

                if (current == data.endNode)
                {
                    Debug.Log("Found END Node");
                    result = true;
                    break;
                }

                List<Node> neighbours = GetNeighbours(data, current);
                foreach (var neighbour in neighbours)
                {
                    if (!visitedNodes.Contains(neighbour))
                    {
                        stack.Push(neighbour);
                        visitedNodes.Add(neighbour);
                    }
                }
            }

            if (!result)
            {
                Debug.Log("We couldn't find a path to the end node");
            }
        }
    }
}