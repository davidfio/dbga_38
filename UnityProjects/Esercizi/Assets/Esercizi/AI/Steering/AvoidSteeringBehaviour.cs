using UnityEngine;
using System.Collections;

namespace AI.SteeringBehaviour
{
    public class AvoidSteeringBehaviour
    {

        public Transform seekTarget;

        public float distanceThreshold = 5;

        // Reference to the movement that must be controlled
        public SteeringMovement movement;

        // Compute the steering contribution of this SteeringBehaviour
        public void ComputeSteering()
        {
            Vector2 targetPosition = seekTarget.transform.position;
            Vector2 myPosition = movement.transform.position;

            Vector2 desideredDirection = (targetPosition - myPosition).normalized;
            desideredDirection = -desideredDirection; // We want to get awey

            float desideredSpeed = 0;
            float distance = (targetPosition - myPosition).magnitude;
            if (distance >= distanceThreshold)
            {
                desideredSpeed = 0;
            }
            else
            {
                desideredSpeed = 1 - distance / distanceThreshold;
            }
            desideredSpeed *= movement.maxSpeed;

            Vector2 desiderdVelocity = desideredDirection * movement.maxSpeed;

            Vector2 desideredAcceleration = desiderdVelocity - movement.state.currentVelocity;
            desideredAcceleration = Vector2.ClampMagnitude(desideredAcceleration, movement.maxAcceleration);

            movement.steeringTarget.acceleration = desideredAcceleration;
        }



    }
}