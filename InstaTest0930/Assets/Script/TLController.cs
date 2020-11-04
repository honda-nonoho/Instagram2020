using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TLController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private TLContentController _TLPrefab = null;   //Story(Prefab)

    //Dictionary(userName)TimeLine
    private Dictionary<int, string> Username = new Dictionary<int, string>();

    int _Loop = 0;
    const string _From = "Prefab/TLContent";
    void Start()
    {
        Load();

        //Dictionaryの宣言
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
                
                var index = i + 1;
                Debug.Log(index);
                var Sprite = Resources.Load<Sprite>("Image/TL" + index.ToString());  //TL画像
                var IconSprite = Resources.Load<Sprite>("Image/Story" + index.ToString());  //Icon画像
 
                var Prefab  = Instantiate<TLContentController>(_TLPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
                
                Prefab.SetPrefab(Username[i],Sprite,IconSprite);
        
            }

        
    }

    // Update is called once per frame
    void Load()
    {
        _TLPrefab = Resources.Load<TLContentController>(_From);
        
    }
}
