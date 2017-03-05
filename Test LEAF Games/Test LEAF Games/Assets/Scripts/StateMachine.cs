using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum InputState
{
    PlayerClose,
    PlayerNotClose,
    BulletClose
}

public abstract class State : MonoBehaviour
{
    public abstract void StateUpdate();
}

public class Transition
{
    public State fromState;
    public InputState input;
    public State toState;

    public Transition(State s1, InputState i, State s2)
    {
        fromState = s1;
        input = i;
        toState = s2;
    }
}

#region Finite State Machine Declaration
public class StateMachine
{
    public State stateIdle;
    public State stateAttack;
    public State stateDodge;

    public State initialState;
    private State currentState;

    List<Transition> transList;

    // Start up the machine
    public void StartMachine()
    {
        this.currentState = initialState;
    } 

    // Create all transitions between states
    public void CreateTransition()
    {
        transList = new List<Transition>();
        transList.Add(new Transition(stateIdle, InputState.PlayerClose, stateAttack));
        transList.Add(new Transition(stateIdle, InputState.BulletClose, stateDodge));
        transList.Add(new Transition(stateAttack, InputState.BulletClose, stateDodge));
        transList.Add(new Transition(stateDodge, InputState.PlayerClose, stateAttack));
        transList.Add(new Transition(stateAttack, InputState.PlayerNotClose, stateIdle));
    }

    // Method that updates the current state of the AI
    public void StateUpdate()
    {
        currentState.StateUpdate();
    }

    // Handle the arrival of an input
    public void HandleInput(InputState i)
    {
        foreach (Transition trans in transList)
        {
            if (trans.input == i && trans.fromState == this.currentState)
            {
                this.currentState = trans.toState;
            }
        }
    }
#endregion
}
