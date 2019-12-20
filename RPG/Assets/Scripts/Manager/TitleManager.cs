using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    Scene scene;
    TitleButton tb;
    //Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        scene = GetComponent<Scene>();
        tb = GameObject.Find("Canvas").GetComponent<TitleButton>();
        //fade = GameObject.FindWithTag("Fade").GetComponent<Fade>();
    }

    // Update is called once per frame
    void Update()
    {
        //fade.isFadeOut = true;

        /* (fade.alpha<=0)
        {
            fade.alpha = 0.0f;
        }*/

        if (tb.isTutorial || tb.isStart || tb.isExit)
        {
            Scene();
        }
    }

    void Scene()
    {
        if (tb.isStart)
        {
            scene.Scenario1();
        }

        if (tb.isExit)
        {
            scene.Exit();
        }

        if (tb.isTutorial)
        {
            scene.Tutorial();
        }
    }

}
