using UnityEngine;
using System.Collections;

namespace AI.SteeringBehaviour
{
    public class SeekSteeringBehaviour
    {

        public Transform seekTarget;



        // Reference to the movement that must be controlled
        public SteeringMovement movement;

        // Compute the steering contribution of this SteeringBehaviour
        public void ComputeSteering()
        {
            Vector2 targetPosition = seekTarget.transform.position;
            Vector2 myPosition = movement.transform.position;

            Vector2 desiredPosition = (targetPosition - myPosition).normalized;

            Vector2 desiderdVelocity = desiredPosition * movement.maxSpeed;

            Vector2 desideredAcceleration = desiderdVelocity - movement.state.currentVelocity;
            desideredAcceleration = Vector2.ClampMagnitude(desideredAcceleration, movement.maxAcceleration);

            movement.steeringTarget.acceleration = desideredAcceleration;
        }



    }
}