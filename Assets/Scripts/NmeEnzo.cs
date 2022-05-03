/*
 Enemy DFA developed by Enzo
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NmeEnzo : Enemy
{
    // STATES:
    // 0 -> initial state
    // 1 -> first state
    // 2 -> second state
    // 3 -> final state

    // NOTE: may have to change in Component window
    //private float currentState = 0;
    //private float finalState = 3; // final state is 3
    // todo: are you able to give each Nme type its own final state in Component?



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void SendToState(char input)
    {
        //throw new System.NotImplementedException();
        switch (currentState)
        {
            case 0:
                State0(input);
                break;
            case 1:
                State1(input);
                break;
            case 2:
                State2(input);
                break;
            case 3:
                State3(input);
                break;
        } // are we rocking with no default :interrobang:
    }

    private void State0(char input)
    {
        // a doesn't change
        if(input == 'b')
        {
            currentState = 1;
        }
    }

    private void State1(char input)
    {
        if(input == 'a')
        {
            currentState = 0;
        } else if(input == 'b')
        {
            currentState = 2;
        }
    }

    private void State2(char input)
    {
        if(input == 'a')
        {
            currentState = 0;
        } else if(input == 'b')
        {
            currentState = 3;
        }
    }

    private void State3(char input)
    {
        // any inputs
        currentState = 0;
    }
}
