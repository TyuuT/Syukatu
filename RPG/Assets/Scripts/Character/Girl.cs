using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public int hp = 5;/*　体力　*/
    public int Maxhp;/*　最大体力　*/
    public int rec = 3;/*　回復量　*/
    [SerializeField]
    int walkCount;
    int walkrnd;
    public float sum;
    public float posX = 4.5f;/*　ポジション指定　*/
    float posY;
    float roteX, roteZ;
    float MaxX;

    SpriteScript ss;


    public Player player;
    private MessageText mt;

    public bool isRecover = false;
    public bool isDef = false;
    public bool isEnd = false;
    public bool isDead = false;
    public bool isRink = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        mt = GameObject.FindWithTag("MessageText").GetComponent<MessageText>();

        ss = GetComponent<SpriteScript>();

        transform.position = new Vector2(posX, posY);
        Maxhp = hp;
        MaxX = posX;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(posX, posY);
        transform.rotation = Quaternion.Euler(roteX, 0, roteZ);
        sum = posX - player.transform.position.x;
        Color();

        if (sum == 0.5f)
        {
            isRink = true;
        }
        if (hp >= Maxhp)
        {
            hp = Maxhp;
        }

        if (posX >= MaxX)
        {
            posX = MaxX;
        }
    }

    public void Turn()
    {
        if (isRink)
        {
            ForRecover();
        }

        if (player.isCall == true)
        {
            walkrnd = Random.Range(1, 3);

            if (walkrnd == 1)
            {
                Walk();
            }

            else
            {
                Rote();
            }
        }

        if (isEnd == false)
        {
            walkCount = Random.Range(1, 5);

            switch (walkCount)
            {
                case 1:
                    Walk();
                    break;
                case 2:
                    Fear();
                    break;
                case 3:
                    Back();
                    break;
                case 4:
                    Recover();
                    break;
            }
        }
        isEnd = false;
    }

    void Recover()
    {
        if (hp <= 1)
        {
            mt.RecoverMe();
            hp = hp + rec;
            isRecover = false;
        }
        else
        {
            Rote();
        }
    }

    void ForRecover()
    {
        player.hp = player.hp + rec;
        mt.RecoverText();
        isDef = true;
        player.isDef = true;
        isEnd = true;
    }

    void Walk()
    {
        //歩くとき
        if (!isRink && sum > 0.5f)
        {
            posX = posX - 1.0f;
            mt.WalkText();
        }
        else
        {
            mt.Arrest();
            isRecover = true;
        }

        player.isCall = false;
        isEnd = true;
    }

    void Fear()
    {
        mt.FearText();
    }

    void Back()
    {
        if (isRink)
        {
            posX = 4.5f;
            isRecover = true;
            mt.BackText();
        }
        else
        {
            Fear();
        }
    }

    public void DefGirl()
    {
        mt.DefGirl();
    }

    public void TurnEnd()
    {
        posY = 0;
        roteX = 0;
        roteZ = 0;

        if (isDef)
        {
            posX = 4.5f;
            isDef = false;
        }
        isRink = false;
    }

    public void End()
    {
        if (hp <= 0)
        {
            hp = 0;
            gameObject.SetActive(false);
            mt.GirlDead();
            isDead = true;
        }
    }

    void Color()
    {
        if (isRink)
        {
            ss.RinkColor();
        }
        else
        {
            ss.Default();
        }
    }

    void Rote()
    {
        posY = -0.5f;
        roteX = 50;
        roteZ = 90;
        mt.RuinedText();
    }
}
