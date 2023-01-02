using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    State _state;
    
    #region State Capsullation
    public State State { get => _state; set => _state = value; }
    #endregion

    private void Awake()
    {
        State = State.MainMneu;
    }

    public void ChnageState(State state)
    {
        State = state;
    }


}
