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
        public State stateIdle;
        public State stateFlee;
        public State stateSearch;

        public State initialState;
        private State currentState;

        List<Transition> transList;

        // Start up the machine
        public void StartMachine()
        {
            this.currentState = initialState;
        }

        public void CreateTransitions()
        {
            // Create all transitions between states
            transList = new List<Transition>();
            transList.Add(new Transition(stateIdle, Input.PlayerClose, stateFlee));
            transList.Add(new Transition(stateFlee, Input.PlayerNotClose, stateIdle));
            transList.Add(new Transition(stateIdle, Input.Timeout, stateSearch));
            transList.Add(new Transition(stateSearch, Input.PlayerClose, stateFlee));
        }


        // Method that updates the current state of the AI
        public void StateUpdate()
        {
            currentState.StateUpdate();
        }

        // Handle the arrival of an input
        public void HandleInput(Input i)
        {
            foreach(var transition in transList)
            {
                if (transition.input == i && transition.fromState == this.currentState)
                {
                    this.currentState = transition.toState;
                }
            }
        }

    }

}
