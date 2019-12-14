using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    MessageText mt;
    Player player;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        mt = GameObject.FindWithTag("MessageText").GetComponent<MessageText>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = mt.player + "\n"
            + player.hp + "/" + player.Maxhp;
    }
}