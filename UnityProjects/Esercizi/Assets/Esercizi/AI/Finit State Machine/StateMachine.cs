using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AI.FSM
{
    public class Transition
    {
        public State fromState;
        public Input input;
        public State toState;

        public Transition(State s1, Input i, State s2)
        {
            fromState = s1;
            input = i;
            toState = s2;
        }
    }
    public class StateMachine 
    {
        //List<State> states;
        public State stateIdle, stateFlee, stateSearch, stateFollow, initialState;
        private State currentState;

        List<Transition> transitions;


        // Start uo the machine
        public void StartMachine()
        {
            this.currentState = initialState;
        }

        public void CreateTransition()
        {
            // Create all transition between states
            transitions = new List<Transition>();
            transitions.Add(new Transition(stateIdle, Input.PlayerClose, stateFlee));
            transitions.Add(new Transition(stateIdle, Input.Timeout, stateSearch));
            transitions.Add(new Transition(stateFlee, Input.PlayerNotClose, stateIdle));
            transitions.Add(new Transition(stateSearch, Input.PlayerClose, stateFlee));
            transitions.Add(new Transition(stateFlee, Input.Superfollow, stateFollow));
            transitions.Add(new Transition(stateFollow, Input.PlayerNotClose, stateIdle));
        }

        // Method that updates the current state of the AI
        public void StateUpdate()
        {
            currentState.StateUpdate();
        }

        // Handle the arrival of an input
        public void HandleInput(Input i)
        {
            foreach (var transition in transitions)
            {
                if (transition.input == i && transition.fromState == this.currentState)
                {
                    this.currentState = transition.toState;
                }
            }
        }
    }
}