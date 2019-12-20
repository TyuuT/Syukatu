using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    SpriteRenderer sr;
    float r, g, b, a;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        r = sr.color.r;
        g = sr.color.g;
        b = sr.color.b;
        a = sr.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        sr.color = new Color(r, g, b, a);
    }

    public void RinkColor()
    {
        r = 0.4f;
        g = 1;
        b = 0;
    }

    public void Default()
    {
        r = 1;
        g = 1;
        b = 1;
    }
}
