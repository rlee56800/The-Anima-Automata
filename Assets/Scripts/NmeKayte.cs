/*
 Enemy DFA developed by Kayte
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NmeKayte : Enemy
{
    // STATES:
    // 0 -> initial state
    // 1 -> first state
    // 2 -> second state
    // 3 -> third state
    // 4 -> fourth state
    // 5 -> fifth state
    // 6 -> final state

    // NOTE: may have to change in Component window
    //private float currentState = 0;
    //private float finalState = 6; // final state is 6
    // todo: are you able to give each Nme type its own final state in Component?



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // KAAAAAAAAAAAAAAYYYYYYYYYYYYYYYYYYYTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEEE.
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
            case 4:
                State4(input);
                break;
            case 5:
                State5(input);
                break;
            case 6:
                State6(input);
                break;
        } // are we rocking with no default :interrobang:
    }

    private void State0(char input)
    {
        if(input == 'a')
        {
            currentState = 1;
        }
        // b doesn't change
    }

    private void State1(char input)
    {
        if (input == 'a')
        {
            currentState = 2;
        }
        else if (input == 'b')
        {
            currentState = 0;
        }
    }

    private void State2(char input)
    {
        if (input == 'a')
        {
            currentState = 0;
        }
        else if (input == 'b')
        {
            currentState = 3;
        }
    }

    private void State3(char input)
    {
        if (input == 'a')
        {
            currentState = 4;
        }
        else if (input == 'b')
        {
            currentState = 0;
        }
    }

    private void State4(char input)
    {
        if (input == 'a')
        {
            currentState = 0;
        }
        else if (input == 'b')
        {
            currentState = 5;
        }
    }

    private void State5(char input)
    {
        if (input == 'a')
        {
            currentState = 0;
        }
        else if (input == 'b')
        {
            currentState = 6;
        }
    }

    private void State6(char input)
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
