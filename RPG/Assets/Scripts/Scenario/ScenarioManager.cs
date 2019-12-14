using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioManager : MonoBehaviour
{
    TextSystem ts;
    Fade fade;
    Scene scene;
    public int ScenarioNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        ts = GameObject.FindWithTag("Text").GetComponent<TextSystem>();
        fade = GameObject.FindWithTag("Fade").GetComponent<Fade>();
        scene = GetComponent<Scene>();
        fade.isFadeOut = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ts.isEndMessage == true)
        {
            fade.isFadeIn = true;

            if (fade.isFade == true)
            {
                switch (ScenarioNumber)
                {
                    case 1:
                        scene.BattleScene();
                        break;
                    case 2:
                        scene.BattleScene2();
                        break;
                }
            }
        }
    }
}
