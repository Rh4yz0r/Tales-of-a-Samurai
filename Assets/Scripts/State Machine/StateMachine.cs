using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using UnityEditorInternal;
using UnityEditor;


public class StateMachine : MonoBehaviour
{
    protected State CurrentState;

    //private int EnumToInt(Enum value) => (int)Convert.ChangeType(value, value.GetTypeCode());

    [Header("States")]

    [SerializeField] int beginState = 0;

    [SerializeField] public List<State> states = new List<State>();
    public List<State> dicks = new List<State>();


    /*protected void CheckStateList()
    {
        if (states.Count <= 0) throw new Exception($"No states have been added to the state machine of {this.gameObject}"); //not working yet as it points to statemachine internal component.
    }

    protected void StateMachineSetup(Enum startState)
    {

    }


    public void TransitionTo(Enum nextState)
    {

    }


    public void NextRandomState(bool excludeStateOptions = false, params Enum[] stateOptions)
    {

    }


    public void NextRandomState(params Enum[] stateOptions)
    {

    }


    public void NextRandomState<T>()
    {

    }*/
}



#if UNITY_EDITOR
[CustomEditor(typeof(StateMachine))]

public class StateEditor : Editor
{
    SerializedProperty states;

    ReorderableList statesReor;


    public override void OnInspectorGUI()
    {
        states = serializedObject.FindProperty("states");

        

        StateMachine _context = (StateMachine)target;

        GUILayout.BeginHorizontal();

        statesReor = new ReorderableList(serializedObject, states, true, true, true, true);

        GUILayout.EndHorizontal();
    }


}
#endif