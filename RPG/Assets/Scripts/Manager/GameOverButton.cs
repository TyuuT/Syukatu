using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverButton : MonoBehaviour
{
    Button button;
    public bool isContinue = false;
    public bool isExit = false;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("Button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnContinue()
    {
        isContinue = true;
    }

    public void OnExit()
    {
        isExit = true;
    }
}
