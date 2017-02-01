using UnityEngine;
using System.Collections;

namespace AI.DecisionTree
{
    // Bot controllato da un Decision Tree
    public class AIBot_DecisionTree : MonoBehaviour
    {
        public Movement movement;
        public DTNode rootNode;

        public void Start()
        {
            StartCoroutine("DoAI");
        }

        IEnumerator DoAI()
        {
            while (true)
            {
                rootNode.MakeDecision();
                Debug.Log("Faccio Coroutine");
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}