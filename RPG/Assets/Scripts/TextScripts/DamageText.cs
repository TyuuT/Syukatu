using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageText : MonoBehaviour
{
    Player player;
    Girl girl;
    Enemy1 enemy;

    float x, y;
    Text text;
    public float timer;

    bool isCount = false;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        girl = GameObject.FindWithTag("Girl").GetComponent<Girl>();
        enemy = GameObject.FindWithTag("Enemy1").GetComponent<Enemy1>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(x, y);
        if(isCount)
        {
            timer += Time.deltaTime;
        }
    }

    public void PlayerDamage()
    {
        text.text = enemy.atk + "";
        x = player.transform.position.x;
        y = player.transform.position.y + 1;
        Timer();
    }

    public void GirlDamage()
    {
        text.text = enemy.atk + "";
        x = girl.transform.position.x;
        y = girl.transform.position.y + 1;
        Timer();
    }

    public void EnemyDamage()
    {
        if(girl.isRink)
        {
            text.text = player.atk + "";
        }
        else
        {
            text.text = player.Satk + "";
        }
        x = enemy.transform.position.x;
        y = enemy.transform.position.y + 1;
        Timer();
    }

    void Timer()
    {
        isCount = true;

        if(isCount)
        {
            if (timer >= 3.0f)
            {
                text.gameObject.SetActive(false);
                timer = 0.0f;
                isCount = false;
            }
        }
    }
}
