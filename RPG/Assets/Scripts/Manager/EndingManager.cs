using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    Scene scene;
    Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        scene = GetComponent<Scene>();
        fade = GameObject.FindWithTag("Fade").GetComponent<Fade>();
        fade.isFadeOut = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fade.isFadeOut = false;
            fade.isFadeIn = true;
        }
        Ending();
    }

    void Ending()
    {
        if (fade.isFade == true)
        {
            scene.Title();
            fade.isFade = false;
        }
    }
}
