using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScenario : MonoBehaviour
{
    SpriteRenderer sr;
    [SerializeField]
    int count = 1;
    public Sprite face1, face2, face3, face4;
    public int change, change2, change3, change4;


    // Start is called before the first frame update
    void Start()
    {
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
        if (count == change)
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
    }
}
