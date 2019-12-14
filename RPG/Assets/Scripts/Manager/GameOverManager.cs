using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    Scene scene;
    GameOverButton gob;
    TurnManager tm;

    // Start is called before the first frame update
    void Start()
    {
        scene = GetComponent<Scene>();
        tm = GameObject.FindWithTag("TurnManager").GetComponent<TurnManager>();
        gob = GameObject.FindWithTag("Button").GetComponent<GameOverButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gob.isContinue)
        {
            OnContinue();
        }
        if (gob.isExit)
        {
            OnExit();
        }
    }

    public void OnContinue()
    {
        switch (tm.ButtleNumber)
        {
            case 1:
                scene.BattleScene();
                break;

            case 2:
                scene.BattleScene2();
                break;
        }
    }

    public void OnExit()
    {
        scene.Exit();
    }
}
