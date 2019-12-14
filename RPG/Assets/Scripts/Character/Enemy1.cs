using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public int hp = 10;/*　体力　*/
    public int Maxhp;/*　最大体力　*/
    public int atk = 1;/*　攻撃力　*/
    int target;
    public int random;

    public Player player;
    public Girl girl;
    private MessageText mt;

    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        girl = GameObject.FindWithTag("Girl").GetComponent<Girl>();

        mt = GameObject.FindWithTag("MessageText").GetComponent<MessageText>();

        Maxhp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp >= Maxhp)
        {
            hp = Maxhp;
        }
    }

    public void Turn()
    {
        random = Random.Range(1, 11);

        if (random >= 2 && !player.isSag)
        {
            Attack();
        }
        else if (random <= 1)
        {
            mt.EnemyMissText();
        }
        else if (player.isSag)
        {
            mt.EnemySagText();
        }
    }

    void Attack()
    {
        target = Random.Range(1, 3);
        switch (target)
        {
            case 1: //プレイヤーに対して
                if (player.isProtect || player.isCall)
                {
                    mt.GapText();
                    player.hp = player.hp - atk * 2;
                }
                else
                {
                    mt.ForPlayerText();
                    player.hp = player.hp - atk;
                }
                break;

            case 2: //少女に対して
                if (player.isProtect == true)
                {
                    mt.ProtectiveText();
                    player.hp = player.hp - atk * 2;
                }
                else
                {
                    mt.ForGirlText();
                    girl.hp = girl.hp - atk;
                }
                break;
        }
    }

    public void DefEnemy()
    {
        mt.DecEnemy();
    }

    public void End()
    {
        if (hp <= 0)
        {
            hp = 0;
            gameObject.SetActive(false);
            mt.text.text = "敵を倒した！！";
            isDead = true;
        }
    }
}
