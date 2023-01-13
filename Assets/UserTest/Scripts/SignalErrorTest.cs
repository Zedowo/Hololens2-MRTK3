using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalErrorTest : MonoBehaviour
{
    private GameplayManager gamePlayManager;

    // Start is called before the first frame update
    void Start()
    {
        gamePlayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gamePlayManager.updateLeftSignal(1);
        gamePlayManager.updateLeftSignal(0);
    }
}
