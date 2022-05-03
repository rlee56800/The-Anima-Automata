// PARENT CLASS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Enemy : MonoBehaviour
{
    //public float health; // current health
    public GameObject target; // self
    //public float maxHealth = 20;
    //public float dmgDealt = 3; // player dmg
    public bool canHit = true; // abe to be hit; not in inivisbiclity frames
    public float iFrames; // invincinility frames

    // vars used for logic
    public float currentState; // overridden by child (but should be 0)
    public float finalState; // overridden by child (depends on dfa)
    public float amtStates = 0; // testing only (until we figure out submit)
    public char input;
    public bool hasChanged = false;

    // animations
    private Animation deathAnim;

    // materials
    public Material stMat; //standard material
    public Material dmgMat; // mat when damaged
    public Material deathMat; // change mat when died; mostly for testing

    public Material shieldHitmat; // tetsubg

    // Start is called before the first frame update
    void Start()
    {
        //health = maxHealth;
        deathAnim = target.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // todo: I don't remember if a parent's OnTriggerEnter works for the children
    private void OnTriggerEnter(Collider collision)
    {
        //target.GetComponent<MeshRenderer>().material = dmgMat;

        if (collision.gameObject.CompareTag("Weapon"))
        {
            input = 'a';
            Debug.Log('a');
        } 
        else if(collision.gameObject.CompareTag("Shield"))
        {
            input = 'b';
            Debug.Log('b');
        }
        hasChanged = true;
        SendToState(input);

        // testing only
        //amtStates++;
        //if(amtStates == 3) //testing
        //{
        //    submit();
        //}

        // OLD GROSS UGLY CODE!! saved bc it worked
        //Debug.Log("entered");
        //if (canPlay && canHit)
        //{
        //    if (collision.gameObject.CompareTag("Weapon"))
        //    {
        //        //Debug.Log("damaging");
        //        //canHit = false;
        //        //TakeDamage(dmgDealt);
        //        StartCoroutine(Invincibility(dmgMat));
        //        dfaIndex = DFACheck('a', dfaIndex);
        //    }
        //    else if (collision.gameObject.CompareTag("Shield"))
        //    {
        //        //canHit = false;
        //        StartCoroutine(Invincibility(shieldHitmat));
        //        dfaIndex = DFACheck('b', dfaIndex);
        //    }
        //}

        //if (canPlay && dfaIndex >= dfa.Length)
        //{
        //    canHit = false;
        //    canPlay = false;
        //    target.GetComponent<MeshRenderer>().material = deathMat;
        //    Debug.Log("DEAD");
        //    Debug.Log("YOU'RE WINNER!");
        //}
    }

    // todo: I don't know the consequences of making this abstract
    // but you can't instantiate it so it should be fine??
    public abstract void SendToState(char input); 
        // allows OnTriggerEnter to send user input to a state

    // trigger when player submits DFA
    public bool submit()
    {
        /*if(currentState == finalState)
        {
            //you're winner
            // confetti effect
            // congration
            Debug.Log("YOU'RE WINNER !");
            SceneManager.LoadScene(1);
            
        } else
        {
            // you suck
            Debug.Log("you suck");
        }*/
        return currentState == finalState;
    }

    /*
    // we might not need anything under here
    private void TakeDamage(float amtDmg)
    {
        //health -= amtDmg;
        Debug.Log(health);
        if(health <= 0)
        {
            canHit = false;
            target.GetComponent<MeshRenderer>().material = deathMat;
            Debug.Log("DEAD");
        } else
        {
            StartCoroutine(Invincibility(dmgMat));
        }
    }

    public IEnumerator Invincibility(Material mat)
    {
        //bool isStandard = true;

        //for (float i = 0; i<=3; i++)
        //{
        //    target.GetComponent<MeshRenderer>().material = isStandard ? dmgMat : stMat;
        //    isStandard = !isStandard;
        //    yield return new WaitForSeconds(iFrames);
        //}
        canHit = false;

        target.GetComponent<MeshRenderer>().material = mat;
        yield return new WaitForSecondsRealtime(iFrames);
        target.GetComponent<MeshRenderer>().material = stMat;
        yield return new WaitForSeconds(iFrames);
        target.GetComponent<MeshRenderer>().material = mat;
        yield return new WaitForSeconds(iFrames);
        target.GetComponent<MeshRenderer>().material = stMat;
        yield return new WaitForSeconds(iFrames);

        canHit = true;

    }

    public float DFACheck(char action, float index)
    {
        if(action.Equals(dfa[(int)index]))
        {
            return index + 1;
        } 
        else
        {
            return 0;
        }
    }*/

}
