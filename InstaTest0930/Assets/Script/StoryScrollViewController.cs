using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private StoryContentController _StroyPrefab = null;   //Story(Prefab)
    
    private Dictionary<int, string> Username = new Dictionary<int, string>();

    int _Loop;
    const string _From = "Prefab/StoryPrefab";
    

    [SerializeField] private StoryPageController _StoryPageObj = null;
    //[SerializeField] private Button _IconButton;

    

    void Start()
    {
        Load();//Dictionaryの宣言
        Username.Add(0,"_Lisa");
        Username.Add(1,"_Selena");
        Username.Add(2,"_Jiso");
        Username.Add(3,"_Rose");
        Username.Add(4,"_Jyeni");
        Username.Add(5,"_Twice");
        Username.Add(6,"_Itzy");
        Username.Add(7,"_mamamoo");
        Username.Add(8,"_Nijiu");
        Username.Add(9,"_Hwasa");

        
        
            

         for(int i = 0; i < 10; i++)
            {
                _Loop++;
                var index = i + 1;
                Debug.Log(index);
                var IconSprite = Resources.Load<Sprite>("Image/Story" + index.ToString());  //Icon画像
                var Prefab  = Instantiate<StoryContentController>(_StroyPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
               
                Prefab.SetPrefab(Username[i],IconSprite);
                Prefab.SetId(_Loop);
                Prefab.CallBuckButton += Test;
            }


        
    }
   
    void Load()
    {
        
        _StroyPrefab = Resources.Load<StoryContentController>(_From);
       

    }

    public void Test()
    {
        Debug.Log("Test");

         _StoryPageObj.SetImg();                   //StoryObj.SertImg()
         _StoryPageObj.gameObject.SetActive(true); //StoryObjをtrueにする

    }
}
