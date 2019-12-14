using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSystem : MonoBehaviour
{
    //　メッセージUI
    [SerializeField]
    private Text dataText;
    //テキストデータ
    [SerializeField]
    private TextAsset textAsset;
    //　表示するメッセージ
    private string loadText;
    //　1回のメッセージの最大文字数
    private int maxTextLength = 100;
    //　1回のメッセージの現在の文字数
    private int textLength = 0;
    //　メッセージの最大行数
    private int maxLine = 1;
    //　現在の行
    private int nowLine = 0;
    //　テキストスピード
    [SerializeField]
    private float textSpeed = 0.05f;
    //　経過時間
    private float elapsedTime = 0f;
    //　今見ている文字番号
    private int nowTextNum = 0;
    //　1回分のメッセージを表示したかどうか
    private bool isOneMessage = false;
    //　メッセージをすべて表示したかどうか
    public bool isEndMessage = false;

    void Start()
    {
        loadText = textAsset.text;
        dataText.text = "";
    }

    void Update()
    {
        //　メッセージが終わっていない、または設定されている
        if (isEndMessage || loadText == null)
        {
            return;
        }
        NotOneMessage();
        OneMessage();
    }


    void NotOneMessage()
    {
        //　1回に表示するメッセージを表示していない	
        if (!isOneMessage)
        {
            //　テキスト表示時間を経過したら
            if (elapsedTime >= textSpeed)
            {
                dataText.text += loadText[nowTextNum];
                //　改行文字だったら行数を足す
                if (loadText[nowTextNum] == '\n')
                {
                    nowLine++;
                }
                nowTextNum++;
                textLength++;
                elapsedTime = 0f;


                //　メッセージを全部表示、または行数が最大数表示された
                if (nowTextNum >= loadText.Length || textLength >= maxTextLength || nowLine >= maxLine)
                {
                    isOneMessage = true;
                }
            }
            elapsedTime += Time.deltaTime;

            //　メッセージ表示中にマウスの左ボタンを押したら一括表示
            if (Input.GetMouseButtonDown(0))
            {
                //　ここまでに表示しているテキストを代入
                var allText = dataText.text;

                //　表示するメッセージ文繰り返す
                for (var i = nowTextNum; i < loadText.Length; i++)
                {
                    allText += loadText[i];

                    if (loadText[i] == '\n')
                    {
                        nowLine++;
                    }
                    nowTextNum++;
                    textLength++;

                    //　メッセージがすべて表示される、または１回表示限度を超えた時
                    if (nowTextNum >= loadText.Length || textLength >= maxTextLength || nowLine >= maxLine)
                    {
                        dataText.text = allText;
                        isOneMessage = true;
                        break;
                    }
                }
            }
            //　1回に表示するメッセージを表示した
        }
    }

    void OneMessage()
    {
        if (isOneMessage)
        {
            elapsedTime += Time.deltaTime;
            //　マウスクリックされたら次の文字表示処理
            if (Input.GetMouseButtonDown(0))
            {
                dataText.text = "";
                nowLine = 0;
                elapsedTime = 0f;
                textLength = 0;
                isOneMessage = false;

                //　メッセージが全部表示されていたらゲームオブジェクト自体の削除
                if (nowTextNum >= loadText.Length)
                {
                    nowTextNum = 0;
                    isEndMessage = true;
                    //　それ以外はテキスト処理関連を初期化して次の文字から表示させる
                }
            }
        }
    }
}
