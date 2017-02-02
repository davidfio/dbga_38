using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Enumerator for transition
public enum Transition
{
    NullTransition = 0,
}

// Enumerator for ID of each State
public enum StateID
{
    NullStateID = 0,
}

#region FSMState
public abstract class FSMState : MonoBehaviour
{
    // A dictionary with Transition and StateID
    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();
    protected StateID stateID;

    // A property that return the StateID
    public StateID ID {get { return stateID; } }

    // Add a transition to the dictionary with a Tansition and a StateID
    public void AddTransition(Transition _trans, StateID _id)
    {
        map.Add(_trans, _id);
    }

    // If exist, delete a transition from the dicitonary
    public void DeleteTransition(Transition _trans)
    {
        if (!map.ContainsKey(_trans))
        {
            Debug.LogError(_trans + " isn't on the tranistion's list");
            return;
        }
        map.Remove(_trans);
    }

    // Method that return a state if thera is passed Transition as argument
    // If there isn't the StateID is null
    public StateID GetOutPutState(Transition _trans)
    {
        return map.ContainsKey(_trans) ? map[_trans] : StateID.NullStateID;
    }
}

#endregion

#region  FSMSystem
public class FSMSystem
{
    // create list of FSMState
    private List<FSMState> statesList;

    // Use the constructor for initialise because isn't MonoBehaviour
    public FSMSystem()
    {
        statesList = new List<FSMState>();
    }

    // The way to change the state of the FSM is to perform a transition
    // NEVER EDIT DIRECTLY CURRENTSTATE
    private StateID _currenStateID;
    public StateID CurretStateID { get { return _currenStateID; } }
    private FSMState _currentState;
    public FSMState CurrentState { get { return _currentState; } }

    // Add a state
    public void AddState(FSMState _state)
    {
        if (_state.Equals(null))
            Debug.LogError("FSM ERROR: Null state isn't allowed");

        // If new state is the first, initialise it
        if (statesList.Count.Equals(0))
        {
            statesList.Add(_state);
            _currentState = _state;
            _currenStateID = _state.ID;
            return;
        }

        // Check if there is the new state's ID
        foreach (FSMState state  in statesList)
        {
            if (state.ID.Equals(_state.ID))
            {
                Debug.LogError("FSM ERROR: Impossibile to add state " + _state.ToString() + " because state has already been added");
                return;
            }
        }

        statesList.Add(_state);
    }


    public void DeleteState(StateID id)
    {
        // Check for NullState before deleting
        if (id == StateID.NullStateID)
        {
            Debug.LogError("FSM ERROR: NullStateID is not allowed for a real state");
            return;
        }

        // Search the List and delete the state if it's inside it
        foreach (FSMState state in statesList)
        {
            if (state.ID == id)
            {
                statesList.Remove(state);
                return;
            }
        }
        Debug.LogError("FSM ERROR: Impossible to delete state " + id.ToString() +
                       ". It was not on the list of states");
    }

    // Make a transition 
    public void MakeTransition(Transition _transition)
    {
        // If new Transition is null return LogError
        if (_transition.Equals(Transition.NullTransition))
        {
            Debug.LogError("FSM ERROR: It isn't allowed NullTransition");
            return;
        }

        // Create a variable StateID with the ID of the new Transition
        StateID id = _currentState.GetOutPutState(_transition);
        // If id is null return LogError
        if (id == StateID.NullStateID)
        {
            Debug.LogError("FSM ERROR: State" + _currenStateID.ToString() + " doesn't have a target state");
            return;
        }

        // Set the variable id as current StateID
        _currenStateID = id;
        // For each FSMState in the state list set the new state
        foreach (FSMState state in statesList)
        {
            if (!state.ID.Equals(_currenStateID)) continue;
            _currentState = state;
            break;
        }
    }
}
#endregion