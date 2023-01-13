using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftTurnSignal : MonoBehaviour
{
    private GameplayManager gamePlayManager;
    //private int value = 0;

    //public GameObject leftTurnText;
    //public GameObject leftTurnStick = GameObject.FindWithTag("TurnSignal");

    // Start is called before the first frame update
    
    /*IEnumerator Blink()
    {
        Debug.Log("Blinker On");

        gamePlayManager.updateLeftSignal(1);
        yield return new WaitForSeconds(2);
        gamePlayManager.updateLeftSignal(0);
        yield return new WaitForSeconds(2);

    }*/

    /*IEnumerator timer()
    {
        while (true)
        {
            if (transform.rotation.z >= 0)
            {
                Debug.Log("Turning");
                gamePlayManager.updateLeftSignal(1);
                gamePlayManager.updateLeftSignal(0);
            }
            else
            {
                Debug.Log("Off");
                gamePlayManager.updateLeftSignal(0);

            }
            yield return new WaitForSeconds(3);
        }
        
    }*/

    void Start()
    {
        //Green Colors is 95 210 20 255, Hex is 5FD214
        gamePlayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    void Awake()
    {
       /* StartCoroutine(timer());*/
    }
    // Update is called once per frame
    void Update()
    {
        gamePlayManager.updateLeftSignal(1);
        gamePlayManager.updateLeftSignal(0);
        //while(transform.rotation.z >= 0)
        //{
        //StartCoroutine(Blink());
        //}
        //gamePlayManager.updateLeftSignal(0);



        /*if (transform.rotation.z >= 0) { //rotation of turn signal at which it is considered "On"
            //leftTurnText.SetActive(true);
            StartCoroutine(Blink());
            //Invoke("gamePlayManager.updateLeftSignal(0)", 0.5f);
        }
        else {
            //leftTurnText.SetActive(false);
            gamePlayManager.updateLeftSignal(0);
        }*/
    }
}
