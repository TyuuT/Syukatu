using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    Button restart;
    Button exit;

    public bool isRestart = false;
    public bool isExit = false;

    // Start is called before the first frame update
    void Start()
    {
        restart = GameObject.FindWithTag("Reset").GetComponent<Button>();
        exit = GameObject.FindWithTag("Exit").GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        isRestart = true;
    }

    public void Exit()
    {
        isExit = true;
    }
}
