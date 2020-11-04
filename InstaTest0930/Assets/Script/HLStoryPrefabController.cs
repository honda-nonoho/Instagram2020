using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HLStoryPrefabController : MonoBehaviour
{
    [SerializeField] private Image _HLStoryImage = null; //HLStoryImg
    [SerializeField] private Text _HLtext  = null;  //Icon下のtext
    
    public void SetPrefab(string text, Sprite sprite)
    {
        //Debug.Log(UnText,sprite,IconSprite);
       
       _HLtext.text = text;
        _HLStoryImage.sprite = sprite;
      
      


    }
}
