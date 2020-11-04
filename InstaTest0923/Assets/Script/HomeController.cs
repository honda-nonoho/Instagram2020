using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeController : MonoBehaviour
{
    //storyの宣言
    [SerializeField] private GameObject _StoryScrollViewContent = null; //storyのスクロールビューのコンテンツ
    private PrefabController _StroryPrefabObj = null; //storyのプレハブオブジェクト
    const string _FromStory = "Prefab/StoryObject"; //storyのプレハブの名前

    //TLの宣言
    // [SerializeField] private GameObject _TLScrollViewContent = null;  //TLのスクロールビューのコンテンツ
    // private PrefabController _TLPrefabObj = null; //TLのプレハブオブジェクト
    // const string _FromTL = "Pefab/TLObject";



    void Start()
    {
      
        //リソーシズ       
        _StroryPrefabObj = Resources.Load<PrefabController>(_FromStory); //story
        //インスタンス         
        var StoryPrefabClone = Instantiate<PrefabController>(_StroryPrefabObj,  Vector3.zero, Quaternion.identity, _StoryScrollViewContent.transform); //story
        //_TLPrefabObj = Resources.Load<PrefabController>(_FromTL);  //TL
        //スプライト
        var Sprite = Resources.Load<Sprite>("Image/IconStory"); //storyのアイコン
        // var TLIcon = Resources.Load<Sprite>("Image/IconMy"); //TLのアイコン
        // var MainImage = Resources.Load<Sprite>("Image/BlackPink"); //投稿の写真
        // var TLIconHert = Resources.Load<Sprite>("Image/IconHert"); //いいね
        // var TLIconComment = Resources.Load<Sprite>("Image/IconComment");  //コメント
        // var TLIconShere = Resources.Load<Sprite>("Image/IconShere");  //シェア
        // var TLIconSave = Resources.Load<Sprite>("Image/IconSave");   //セーブ
        
    
    
        
        //var TLPrefabClone = Instantiate<PrefabController>(_TLPrefabObj,  Vector3.zero, Quaternion.identity, _TLScrollViewContent.transform);  //TL

        StoryPrefabClone.SetStorySprite(Sprite); //StoryIcon
        // TLPrefabClone.SetTLSprite(TLIcon);
        // TLPrefabClone.SetTLSprite(MainImage);
        // TLPrefabClone.SetTLSprite(TLIconHert);
        // TLPrefabClone.SetTLSprite(TLIconComment);
        // TLPrefabClone.SetTLSprite(TLIconShere);
        // TLPrefabClone.SetTLSprite(TLIconSave);
      }
    
}
