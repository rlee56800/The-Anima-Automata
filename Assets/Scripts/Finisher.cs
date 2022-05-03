using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finisher : MonoBehaviour
{
    public Enemy enemy;

    // invinibilty
    public bool canHit = true; // abe to be hit; not in inivisbiclity frames
    public float iFrames; // invincinility frames
    public Material stMat; //standard material
    public Material dmgMat; // mat when damaged
    public Material victoryMat; // mat when dfa is correct
    public GameObject tofu; // self (for color change)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(canHit)
        {
            if (collision.gameObject.CompareTag("Weapon") || collision.gameObject.CompareTag("Shield"))
            {
                //enemy.submit();
                if (enemy.submit())
                {
                    //you're winner
                    // confetti effect
                    // congration
                    Debug.Log("YOU'RE WINNER !");
                    StartCoroutine(Correct());
                }
                else
                {
                    // you suck
                    Debug.Log("you suck");
                    StartCoroutine(Invincibility());
                }
            }
        }

    }

    public IEnumerator Invincibility()
    {
        canHit = false;

        tofu.GetComponent<MeshRenderer>().material = dmgMat;
        yield return new WaitForSecondsRealtime(iFrames);
        tofu.GetComponent<MeshRenderer>().material = stMat;
        yield return new WaitForSeconds(iFrames);
        tofu.GetComponent<MeshRenderer>().material = dmgMat;
        yield return new WaitForSeconds(iFrames);
        tofu.GetComponent<MeshRenderer>().material = stMat;
        yield return new WaitForSeconds(iFrames);
        tofu.GetComponent<MeshRenderer>().material = dmgMat;
        yield return new WaitForSeconds(iFrames);
        tofu.GetComponent<MeshRenderer>().material = stMat;
        yield return new WaitForSeconds(iFrames);

        canHit = true;

    }

    public IEnumerator Correct()
    {
        canHit = false; // this may cause problems down the line btw
        tofu.GetComponent<MeshRenderer>().material = victoryMat;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
