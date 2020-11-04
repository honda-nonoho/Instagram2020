using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  //タイムラインへ

public class PostScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    [SerializeField] private GameObject _PostObj = null;
    [SerializeField] private GameObject _TVObj = null; //TVObject
    [SerializeField] private GameObject _TagObj = null; //TagObject
    [SerializeField] private GameObject _EditObj = null;  //EditObject
    private PostPrefabController _PostPrefab = null;
    [SerializeField ] private Button _PostButton = null; //PostButton
    
    const string _From = "Prefab/PostPrefab";

    void Start()
    {
        Load();
        for(int i = 0; i < 12; i++)
        {
            var index = i + 1;
            Debug.Log(index);
            var Sprite =  Resources.Load<Sprite>("Image/Post" + index.ToString());  //PostのResources

            var Prefab  = Instantiate<PostPrefabController>(_PostPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); //インスタンス生成
            Prefab.GetComponent<RectTransform>().localPosition = Vector3.zero;

    
            Prefab.SetPrefab(Sprite);
        }
        // _TVObj.SetActive(false);
        // _TagObj.SetActive(false);
        // _EditObj.SetActive(false);

        _PostButton.onClick.AddListener(OnClickPostButton);
    }

     void OnClickPostButton()
    {
        Debug.Log("aaaaaaaa");
  
        _PostObj.SetActive(true);
        _TVObj.SetActive(false);
        _TagObj.SetActive(false);
        _EditObj.SetActive(false);
    }
    
    void Load()
    {
        _PostPrefab = Resources.Load<PostPrefabController>(_From);
        Debug.Log("Load");
    }
}
