using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleButton : MonoBehaviour
{
    Button button;
    public bool isStart = false;
    public bool isExit = false;
    public bool isTutorial = false;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("Button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStart()
    {
        isStart = true;
    }

    public void OnExit()
    {
        isExit = true;
    }

    public void OnTutorial()
    {
        isTutorial = true;
    }
}
