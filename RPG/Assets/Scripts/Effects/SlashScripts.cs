using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashScripts : MonoBehaviour
{
    Animator anim;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    public void startAnim()
    {

        if (anim)
        {

            anim.Play("slash");

        }

    }
}
