using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    //プレイヤー処理
    public Player player;

    //少女処理
    public Girl girl;

    //エネミー1処理
    public Enemy1 enemy;

    //その他処理
    private Fade fade;
    private Scene scene;
    private ResetButton reset;
    public int turn = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        girl = GameObject.FindWithTag("Girl").GetComponent<Girl>();
        enemy = GameObject.FindWithTag("Enemy1").GetComponent<Enemy1>();

        fade = GameObject.FindWithTag("Fade").GetComponent<Fade>();
        scene = GetComponent<Scene>();
        reset = GameObject.FindWithTag("Button").GetComponent<ResetButton>();
        fade.isFadeOut = true;
    }

    // Update is called once per frame
    void Update()
    {
        switch (turn)
        {
            case 0:
                player.DefPlayer();
                break;

            case 2:
                girl.DefGirl();
                break;

            case 3:
                GirlTurn();
                break;

            case 5:
                enemy.DefEnemy();
                break;

            case 6:
                Enemy1Turn();
                break;

            case 8:
                player.TurnEnd();
                girl.TurnEnd(); ;
                turn = 0;
                break;
        }
        EndTurn();
        End();
    }

    public void PlayerAttack()
    {
        if (girl.isRink == true)
        {
            player.SpecialAttack();
        }
        else
        {
            player.Attack();
        }
        turn++;
    }

    public void PlayerProtect()
    {
        player.Protect();
        turn++;
    }

    public void PlayerCall()
    {
        player.Call();
        turn++;
    }

    void GirlTurn()
    {
        girl.Turn();
        turn++;
    }

    void Enemy1Turn()
    {
        enemy.Turn();
        turn++;
    }

    void EndTurn()
    {
        player.Dead();
        girl.End();
        enemy.End();
    }

    void End()
    {
        if(reset.isExit||reset.isRestart)
        {
            fade.isFadeIn = true;

            if(fade.isFade)
            {
                if(reset.isRestart)
                {
                    scene.Tutorial();
                }
                if(reset.isExit)
                {
                    scene.Title();
                }
            }
        }
    }

    public void Count()
    {
        turn++;
    }
}
