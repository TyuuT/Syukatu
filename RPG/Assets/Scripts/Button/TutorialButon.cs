using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialButon : MonoBehaviour
{
    Button attack;
    Button defense;
    Button call;
    Button skip;

    public TutorialManager tm;

    // Start is called before the first frame update
    void Start()
    {
        attack = GameObject.FindWithTag("Attack").GetComponent<Button>();
        defense = GameObject.FindWithTag("Defense").GetComponent<Button>();
        call = GameObject.FindWithTag("Call").GetComponent<Button>();
        skip = GameObject.FindWithTag("Skip").GetComponent<Button>();

        tm = GameObject.Find("TurnManager").GetComponent<TutorialManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Enabled();
    }

    public void OnAttack()
    {
        tm.PlayerAttack();
    }

    public void OnProtect()
    {
        tm.PlayerProtect();
    }

    public void OnCall()
    {
        tm.PlayerCall();
    }

    public void OnSkip()
    {
        tm.Count();
    }

    void Enabled()
    {
        if (tm.turn >= 1)
        {
            attack.interactable = false;
            defense.interactable = false;
            call.interactable = false;
            skip.gameObject.SetActive(true);
        }
        else if (tm.turn == 0)
        {
            attack.interactable = true;
            defense.interactable = true;
            call.interactable = true;
            skip.gameObject.SetActive(false);
        }
    }
}
