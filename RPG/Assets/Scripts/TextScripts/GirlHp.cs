using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlHp : MonoBehaviour
{
    MessageText mt;
    Girl girl;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        mt = GameObject.FindWithTag("MessageText").GetComponent<MessageText>();
        girl = GameObject.FindWithTag("Girl").GetComponent<Girl>();
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = mt.girl + "\n"
            + girl.hp + "/" + girl.Maxhp;
    }
}
