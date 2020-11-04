using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotController : MonoBehaviour
{
    public Text _BotText; //相手側のテキスト
    public Image _BotIcon; //相手側のアイコンの写真の宣言
    public Image _BotImage; //相手側の投稿写真の宣言
    public void SetBotText(string text)
    {
        

        Debug.Log(text);
        Debug.Log(_BotText);
       
         _BotText.text = text;
        
    }

    public void SetSpriteBot(Sprite sprite)
    {
         Debug.Log(sprite);
        _BotIcon.sprite = sprite;
        _BotImage.sprite = sprite;
    }
}
