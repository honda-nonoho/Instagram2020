using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StroyController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private StoryContentController _StroyPrefab = null;   //Story(Prefab)

    int _Loop;
    const string _From = "Prefab/Button";
     
    [SerializeField] private StoryPageController _StoryPageObj = null;

    void Start()
    {
        
            Load();
            Debug.Log("Start");

                
             for(int i = 0; i < 10; i++)
            {
                _Loop++;
                int index = i + 1;
                var Sprite = Resources.Load<Sprite>("Image/Story" + index.ToString()); //storyのSpriteのリソーシズロード
                var Prefab  = Instantiate<StoryContentController>(_StroyPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
                Prefab.SetSprite(Sprite);
                Prefab.SetId(_Loop);  //idをセットさせる
                Prefab.CallBuckButton += Test; //PrefabとCallBuckを行う

            }
                
    }
    

    // Update is called once per frame
    void Load()
    {
        
        _StroyPrefab = Resources.Load<StoryContentController>(_From);  //ScrollViewのコンテンツのリソーシズ(Button)
    
        Debug.Log("Load");
    }

    public void Test()
    {
        Debug.Log("Test");
        _StoryPageObj.SetImg(); //SetImagのメゾットを使う
        _StoryPageObj.gameObject.SetActive(true);  //StoryObjを表示する (gameObjectのUIをとる)

    }
}
