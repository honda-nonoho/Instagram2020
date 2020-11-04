using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;  //CallBuckしたい時にActionが使えるように

public class StoryContentController : MonoBehaviour
{
    public int id;
    //Buttonについて,StoryControllerで使ってるコンテンツのUIの宣言
    [SerializeField] private Button _StoryIconButton = null;
    //StoryContentのボタンの上の画像の宣言
    [SerializeField] private Image _StoryIconImage = null;
    
    public Action CallBuckButton = null;  //コールバック
   
    
    void Start()
    {
        _StoryIconButton.onClick.AddListener(OnClickAcut);//イベント登録

    }
    void OnClickAcut()
    {
        Debug.Log(id);
        PlayerPrefs.SetInt("id", id);  //AccountControllerのStart関数でGetしている。ストーリーのアイコンを押すとidがセットされる
        if(CallBuckButton != null); //何か会ったら
        {
            CallBuckButton.Invoke();
        }
       
        Debug.Log("OnClickAcut");
        
    } 

    public void SetId(int dataId)
    {
        id = dataId;  //IdをセットさせるStoryControllerのPrefab.SetId(_Loop);
    }
    public void SetSprite(Sprite sprite)
    {
        Debug.Log(sprite);
         _StoryIconImage.sprite = sprite;

    }
}
