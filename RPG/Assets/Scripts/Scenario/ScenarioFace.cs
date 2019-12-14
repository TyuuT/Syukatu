using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioFace : MonoBehaviour
{
    ScenarioManager sm;
    SpriteRenderer sr;
    [SerializeField]
    int count = 1;
    public Sprite face1, face2, face3, face4, face5,face6;
    public int change1, change2, change3, change4, change5,change6;


    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindWithTag("ScenarioManager").GetComponent<ScenarioManager>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
        }
        ChangeSprite();
    }

    void ChangeSprite()
    {
        if (count == change1)
        {
            sr.sprite = face1;
        }
        if (count == change2)
        {
            sr.sprite = face2;
        }

        if (count == change3)
        {
            sr.sprite = face3;
        }

        if (count == change4)
        {
            sr.sprite = face4;
        }
        if (count == change5)
        {
            sr.sprite = face5;
        }
        if (count == change6)
        {
            sr.sprite = face6;
        }
    }
}
