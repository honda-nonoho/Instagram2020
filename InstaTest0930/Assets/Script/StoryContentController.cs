using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StoryContentController : MonoBehaviour
{
    public int id;
   

     [SerializeField] private Button _StoryIconButton = null;
    [SerializeField] private Image _IconImage = null;
    [SerializeField] private Text _UserName = null;
    
   
    public Action CallBuckButton = null;  //コールバック

     void Start()
    {
        _StoryIconButton.onClick.AddListener(OnClickAcut);//イベント登録
    }
    void OnClickAcut()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton != null)
        {
          CallBuckButton.Invoke();
        }
        Debug.Log("OnClickAcut");
    } 

    public void SetId(int dataId)
    {
        id = dataId;  
    }

    public void SetPrefab(string UnText,Sprite IconSprite)
    {
        _UserName.text = UnText;
        _IconImage.sprite = IconSprite;
    }
}
