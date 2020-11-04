using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HLStoryScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private HLStoryPrefabController _HLStoryPrefab = null;  //Pist(Prefab)
    int _Loop = 0;
    const string _From = "Prefab/HLStoryPrefab";
    private Dictionary<int,string> dicText = new Dictionary<int, string>(); //Icon下のtext dictionary


    // Start is called before the first frame update
    void Start()
    {
        Load();
        //dicTextのAdd
        dicText.Add(0,"木村");
        dicText.Add(1,"まりの");
        dicText.Add(2,"人狼メン");
        dicText.Add(3,"推しぴ");
        dicText.Add(4,"ラッパーの練...");
        dicText.Add(5,"開幕投手");
        dicText.Add(6,"同担拒否");

        Debug.Log("Start");

        for(int i = 0; i < 7; i++)
        {
            
            var index = i + 1;
            Debug.Log(index);
            var Sprite = Resources.Load<Sprite>("Image/HLImg" + index.ToString()); //HLStoryIcon画像
                                                                                            
            var Prefab = Instantiate<HLStoryPrefabController>(_HLStoryPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
            Prefab.GetComponent<RectTransform>().localPosition = Vector3.zero;

            Prefab.SetPrefab(dicText[i],Sprite);
        }
        void Load()
        {
            _HLStoryPrefab = Resources.Load<HLStoryPrefabController>(_From);
            Debug.Log("Load");
        }


        
    }
}
