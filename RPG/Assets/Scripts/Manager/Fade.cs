using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    Image image;
    public float alpha;
    [SerializeField]
    float speed = 0.01f;

    public bool isFadeIn = false;
    public bool isFadeOut = false;
    public bool isFade = false;


    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        alpha = image.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn == true)
        {
            FadeIn();
        }

        if (isFadeOut == true)
        {
            FadeOut();
        }
    }

    public void FadeIn()
    {
        image.enabled = true;
        alpha += speed;
        SetAlpha();
        if (alpha >= 1)
        {
            isFadeIn = false;
            isFade = true;
        }
    }

    public void FadeOut()
    {
        alpha -= speed;
        SetAlpha();
        if (alpha <= 0)
        {
            isFadeOut = false;
            image.enabled = false;
            isFade = false;
        }
    }

    void SetAlpha()
    {
        image.color = new Color(0.0f, 0.0f, 0.0f, alpha);
    }
}
