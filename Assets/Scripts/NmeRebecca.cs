/*
 Enemy DFA developed by Rebecca
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NmeRebecca : Enemy
{
    // STATES:
    // 0 -> initial state
    // 1 -> first state
    // 2 -> final state

    // NOTE: may have to change in Component window
    //static float currentState = 0;
    //static float finalState = 2; // final state is 2



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
        } // are we rocking with no default :interrobang:
    }

    private void State0(char input)
    {
        if (input == 'a')
        {
            currentState = 1;
        }
        // b doesn't change state
    }

    private void State1(char input)
    {
        if (input == 'a')
        {
            currentState = 2;
        } else if (input == 'b')
        {
            currentState = 0;
        }
    }

    private void State2(char input)
    {
        if (input == 'a')
        {
            currentState = 1;
        }
        else if (input == 'b')
        {
            currentState = 0;
        }
    }
}
