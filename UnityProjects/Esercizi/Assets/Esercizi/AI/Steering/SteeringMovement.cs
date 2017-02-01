using UnityEngine;
using System.Collections;

namespace AI.SteeringBehaviour
{
    // Target vector for velocity update
    public struct SteeringTarget
    {
        public Vector2 acceleration;
    }


    // Movement state
    [System.Serializable]
    public struct SteeringState
    {
        public Vector2 currentVelocity;

    }

    // Movement logic
    public class SteeringMovement : MonoBehaviour
    {
        public SteeringState state;

        public SteeringTarget steeringTarget;

        public float maxSpeed = 5f;
        public float maxAcceleration = 20f;

        void Update()
        {
            Debug.DrawLine(this.transform.position, this.transform.position + (Vector3)steeringTarget.acceleration, Color.green);
            Debug.DrawLine(this.transform.position, (Vector3)state.currentVelocity + this.transform.position, Color.red);




            // Compute steering
            state.currentVelocity += steeringTarget.acceleration * Time.deltaTime;


            // Forward Euler integration
            transform.position += (Vector3)(state.currentVelocity * Time.deltaTime);
        }



    }
}