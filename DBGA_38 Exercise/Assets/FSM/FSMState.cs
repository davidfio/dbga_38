using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Transition
{
    NullTransition = 0,
}

public enum StateID
{
    NullStateID = 0,
}

public abstract class FSMState : MonoBehaviour
{
    
    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();
    protected StateID stateID;

    public StateID ID {get { return stateID; } }

    public void AddTransition(Transition _trans, StateID _id)
    {
        map.Add(_trans, _id);
    }

    public void DeleteTransition(Transition _trans)
    {
        if (!map.ContainsKey(_trans))
        {
            Debug.LogError(_trans + " isn't on the tranistion's list");
            return;
        }
        map.Remove(_trans);
    }

    public StateID GetOutPutState(Transition _trans)
    {
        return map.ContainsKey(_trans) ? map[_trans] : StateID.NullStateID;
    }
}

public class FSMSystem
{
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
}
