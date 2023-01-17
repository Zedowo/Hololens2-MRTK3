using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTurnSignalPrint : MonoBehaviour
{
    private GameplayManager gamePlayManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        gamePlayManager = GameObject.FindObjectOfType<GameplayManager>();
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        while (true)
        {
            if (transform.rotation.z <= 0)
            {
                gamePlayManager.updateRightSignal(1);
                yield return new WaitForSeconds(0.5f);
                gamePlayManager.updateRightSignal(0);
            }
            else
            {
                gamePlayManager.updateRightSignal(0);
            }
            yield return new WaitForSeconds(0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
