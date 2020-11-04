using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLineController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private TLContentController _TLPrefab = null;   //Story(Prefab)

    //Dictionary(userName)TimeLine
    private Dictionary<int, string> username = new Dictionary<int, string>();

    int _Loop = 0;
    // public string[] _TLSprites = new string[10];
    // public string[] _IconSprites = new string[10];
    const string _From = "Prefab/PrefabObj";

    //botの宣言
    //Dicの宣言
   private Dictionary<int, Sprite> dic = new Dictionary<int, Sprite>();
    //相手側のprefab
   private BotController _BotContent = null;
   const string _FromBot = "Prefab/BotObj";
   
    
    // Start is called before the first frame update
    void Start()
    {
        Load();
        //username(Dictionary)の宣言
        username.Add(0,"_Lisa_0");
        username.Add(1,"_Selena1");
        username.Add(2,"_Jisoo2");
        username.Add(3,"_Rose3");
        username.Add(4,"_Jenyi");
        username.Add(5,"_twice");
        username.Add(6,"_itzy");
        username.Add(7,"_mamamoo");
        username.Add(8,"_nijiu");
        username.Add(9,"_hwasa10");
       

        //dicの宣言
        dic.Add(0, Resources.Load<Sprite>("Image/Story1"));
        dic.Add(1, Resources.Load<Sprite>("Image/Story2"));
        dic.Add(2, Resources.Load<Sprite>("Image/Story3"));
        dic.Add(3, Resources.Load<Sprite>("Image/Story4"));
        dic.Add(4, Resources.Load<Sprite>("Image/Story5"));
        dic.Add(5, Resources.Load<Sprite>("Image/Story6"));
        dic.Add(6, Resources.Load<Sprite>("Image/Story7"));
        dic.Add(7, Resources.Load<Sprite>("Image/Story8"));
        dic.Add(8, Resources.Load<Sprite>("Image/Story9"));
        dic.Add(9, Resources.Load<Sprite>("Image/Story10"));
       
        //hjhhh.Add(0,Resources.Load<Sprite>("Image/Icon"));

            Debug.Log("Start");

                
             for(int i = 0; i < 10; i++)
            {
                
                var index = i + 1;
                Debug.Log(index);
                var Sprite = Resources.Load<Sprite>("Image/TL" + index.ToString());  //TL画像
                var IconSprite = Resources.Load<Sprite>("Image/Story" + index.ToString());  //Icon画像
 
                var Prefab  = Instantiate<TLContentController>(_TLPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
                
                Prefab.SetPrefab(username[i],Sprite,IconSprite);
        
            }

        _BotContent = Resources.Load<BotController>(_FromBot);
        
    
    }


    IEnumerator Test()  //botの処理→StartCrouttine
        {
            yield return new WaitForSeconds(5);//何秒後に

            Debug.Log(dic[_Loop]); //dicの中のKeyの値をDebugLogで表示、表示されるのはvalue
            //インスタンスのクローンの生成 
            var PrefabClone = Instantiate<BotController>(_BotContent, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
            //PrefabClone.SetBotText(dic[_Loop]);//インスタンスにテキストを渡して表示する
            if(_Loop == 6)
            {
                _Loop = 0; //dicのkeyが10までいったら０になる
            }else{
                _Loop++; //10じゃなければカウントアップの処理をする
            }

            var BotSprite = Resources.Load<Sprite>("Image/Story2"); //相手側のアイコンの写真
            PrefabClone.SetSpriteBot(BotSprite); 
        

            
        }


    void Load()
    {
        StartCoroutine("Test");  //botの処理   
        
        _TLPrefab = Resources.Load<TLContentController>(_From);
    
        Debug.Log("Load");
    }
}
