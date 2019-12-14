using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //ステータス
    public int hp = 10;/*　体力　*/
    public int Maxhp;/*　最大体力　*/
    public int atk = 1;/*　攻撃力　*/
    public int Satk;/*　必殺技の攻撃力　*/
    public float x, y;/*　ポジション指定　*/
    public float MaxX = 4;
    float roteY;
    int sag;

    //描画
    SpriteRenderer sr;
    float r, g, b, a;

    public Girl girl;
    public Enemy1 enemy;
    private MessageText mt;

    public bool isSag = false;/*　怯ませているか　*/
    public bool isProtect = false;
    public bool isDef = false;
    public bool isDead = false;
    public bool isCall = false;

    // Start is called before the first frame update
    void Start()
    {
        girl = GameObject.FindWithTag("Girl").GetComponent<Girl>();
        enemy = GameObject.FindWithTag("Enemy1").GetComponent<Enemy1>();
        mt = GameObject.FindWithTag("MessageText").GetComponent<MessageText>();
        sr = GetComponent<SpriteRenderer>();
        r = sr.color.r;
        g = sr.color.g;
        b = sr.color.b;
        a = sr.color.a;

        Maxhp = hp;
        x = -1;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp >= Maxhp)
        {
            hp = Maxhp;
        }
        if (x >= MaxX)
        {
            x = MaxX;
        }

        Color();
        transform.position = new Vector2(x, y);
        transform.rotation = Quaternion.Euler(0, roteY, 0);
    }

    public void DefPlayer()
    {
        mt.DecPlayer();
    }

    public void Attack()
    {
        sag = Random.Range(1, 11);

        x = enemy.transform.position.x + 2;
        enemy.hp = enemy.hp - atk;
        mt.AttackText();

        if (sag <= 1)
        {
            isSag = true;
        }
    }

    public void SpecialAttack()
    {
        x = enemy.transform.position.x + 2;
        isDef = true;
        girl.isDef = true;
        enemy.hp = enemy.hp - Satk;
        mt.SpecialAttackText();
        girl.isRink = false;
    }

    public void Protect()
    {
        if (girl.isRink == true)
        {
            mt.ProtectText();
            isProtect = true;
        }
        else
        {
            x = x + 1;
            roteY = 180;
            mt.Protective();
            isProtect = false;
        }
    }

    public void Call()
    {
        mt.CallText();
        roteY = 180;
        isCall = true;
    }

    public void TurnEnd()
    {
        roteY = 0;

        if (isDef)
        {
            x = -1;
            isDef = false;
        }
        isCall = false;
        isSag = false;
    }

    public void Dead()
    {
        if (hp <= 0)
        {
            hp = 0;
            gameObject.SetActive(false);
            mt.PlayerDead();
            isDead = true;
        }
    }

    void Color()
    {
        if (girl.isRink)
        {
            r = 0.4f;
            g = 1;
            b = 0;
        }
        else
        {
            r = 1;
            g = 1;
            b = 1;
        }
        sr.color = new Color(r, g, b, a);
    }
}
