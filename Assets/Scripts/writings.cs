using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/* should display as:
 * [HINT]
 * CURRENT STATE:
 * LAST ACTION:
 */
public class writings : MonoBehaviour
{
    public Enemy enemy;
    public TextMeshPro boxText;
    public char prevAction = 'x';
    // from Enemy:
    //  current state
    //  input

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(enemy.currentState);
        //boxText = GetComponent<Text>();
        //boxText.text = "HINT\nCURRENT STATE: " + enemy.currentState + "\nLAST ACTION:" + enemy.input;
        //Debug.Log("HINT\nCURRENT STATE: " + enemy.currentState + "\nLAST ACTION:" + enemy.input);
        //Debug.Log("jh:");
        boxText.text = "Hit the enemy!";
    }

    //Update is called once per frame
    void Update()
    {
       if(enemy.hasChanged)
       {
           enemy.hasChanged = false;
           boxText.text = "HINT\nCURRENT STATE: " + (enemy.currentState + 1) + 
                          "\nCURRENT ACTION: " + enemy.input + 
                          "\nLAST ACTION: " + prevAction.ToString();
           prevAction = enemy.input;
       }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(enemy.hasChanged)
    //    {
    //        enemy.hasChanged = false;
    //        //print("FROM WRITING" +enemy.input);
    //    }
    //}

    //public static GameObject text = new GameObject();
    //public TextMesh t = text.AddComponent<TextMesh>();
    //t.text = "new text set";
    //t.fontSize = 30;
}
