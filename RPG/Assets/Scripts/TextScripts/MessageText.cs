using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageText : MonoBehaviour
{
    //　読み込んだテキストを出力するUIテキスト
    public Text text;
    public string player, girl, enemy;

    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    void Update()
    {

    }

    //プレイヤーターン時のテキスト
    public void DecPlayer()
    {
        text.text = "「さて、どうするか…」\n" + player + "はどうする･･･？";
    }
    public void AttackText()
    {
        text.text = "「くらえっ！！」\n" + player + "は攻撃した";
    }
    public void SpecialAttackText()
    {
        text.text = "「これで、終わりだ！！」\n" + player + "と" + girl + "のリンク攻撃！\n"
            +"そして"+girl+"は下がる";
    }
    public void ProtectText()
    {
        text.text = "「危ないっ！！」\n庇う体制に入った。";
    }
    public void Protective()
    {
        text.text = "「っ！？」\n庇うために移動した。";
    }
    public void CallText()
    {
        text.text = "「手を貸してくれ･･･！！」\n" + girl + "を呼ぶ…";
    }

    //少女ターン時のテキスト
    public void DefGirl()
    {
        text.text = "「私はどうしたら…？」\n" + girl + "のターン。";
    }
    public void FearText()
    {
        text.text = "「ひぃっ･･･！」\n" + girl + "は怯んでいる…";
    }

    public void RecoverMe()
    {
        text.text = "「使わないと･･･」\n" + girl + "は回復薬を自分で使った";
    }
    public void RecoverText()
    {
        text.text = "「これを･･･使って！」\n" + girl + "は回復薬を渡し、下がる";
    }
    public void RuinedText()
    {
        text.text = "「あいたっ･･･！」\n" + girl + "は…こけた";
    }
    public void WalkText()
    {
        text.text = "「行かないと･･･！」\n" + girl + "は歩き出した。";
    }
    public void Arrest()
    {
        text.text = "「待てって！」\n" + player + "は歩こうとする\n" + girl + "を引き留めた";
    }
    public void BackText()
    {
        text.text = "「ひゃぁ！？」\n" + girl + "は戻ってしまった";
    }

    //敵ターン時のテキスト
    public void DecEnemy()
    {
        text.text = "（" + enemy + "が仕掛けてくる･･･！）\n" + enemy + "の攻撃。";
    }
    public void ForPlayerText()
    {
        text.text = "「ぐっ･･･！！」\n" + enemy + "は" + player + "に攻撃した。";
    }
    public void GapText()
    {
        text.text = "「しまっ･･･」\n" + player + "はダメージ倍増！";
    }
    public void ForGirlText()
    {
        text.text = "「きゃっ！？」\n" + enemy + "は" + girl + "に攻撃した";
    }
    public void ProtectiveText()
    {
        text.text = "「だ、大丈夫か･･･？」\n" + enemy + "の攻撃。\n" + player + "が庇っている\nダメージ増加。";
    }
    public void EnemyMissText()
    {
        text.text = "しかし、" + enemy + "の攻撃は外れた。";
    }
    public void EnemySagText()
    {
        text.text = enemy + "は怯んでいる！！";
    }

    //死亡時のテキスト
    public void PlayerDead()
    {
        text.text = "「くそ･･･こんな･･･所･･･で･･･」\n" + player + "は力尽きてしまった…";
    }
    public void GirlDead()
    {
        text.text = "「ﾏﾓﾚﾅｶｯﾀ･･･」\n" + girl + "は力尽きてしまった…";
    }
    public void EnemyDead()
    {
        text.text = "「よしっ、倒した！！」\n" + enemy + "を倒した！！";
    }
}

