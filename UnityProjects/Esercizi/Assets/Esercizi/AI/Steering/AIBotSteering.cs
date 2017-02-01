using UnityEngine;
using System.Collections;

namespace AI.SteeringBehaviour
{
    public class AIBotSteering : MonoBehaviour
    {
        SeekSteeringBehaviour sb;
        AvoidSteeringBehaviour ab;

        void Start()
        {
            var movement = GetComponent<SteeringMovement>();
            // Steup steering (decision making)
            sb = new SeekSteeringBehaviour();
            sb.movement = movement;
            sb.seekTarget = FindObjectOfType<Player>().transform;

            ab = new AvoidSteeringBehaviour();
            ab.movement = movement;
            ab.seekTarget = FindObjectOfType<Player>().transform;
        }

        void Update()
        {
            ab.ComputeSteering();
        }
    }
}