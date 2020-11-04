using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryPageController : MonoBehaviour
{
    //obj内で使用するUI
    [SerializeField] private Image _StoryImg = null;
    [SerializeField] private Button _CancelButton = null;
    //SetActiveに使用するobjの宣言
    [SerializeField] private GameObject _StoryPageObj = null; //表示したいobj
    [SerializeField] private GameObject _StoryObj = null;  //非表示したいobj
    [SerializeField] private GameObject _TLObj = null;     //非表示したいobj

    //StoryImgの表示したいリソーシズたちのDictionary型
    Dictionary<int,Sprite> _Img = new Dictionary<int, Sprite>();

    void Start()
    {
        //最初はこのobjは非表示
        this.gameObject.SetActive(false);
        //キャンセルボタンのイベント登録
        _CancelButton.onClick.AddListener(onClickCancel);

        //Dictionaryの宣言
        _Img.Add(1,Resources.Load<Sprite>("Image/SP1"));
        _Img.Add(2,Resources.Load<Sprite>("Image/SP2"));
        _Img.Add(3,Resources.Load<Sprite>("Image/SP3"));
        _Img.Add(4,Resources.Load<Sprite>("Image/SP4"));
        _Img.Add(5,Resources.Load<Sprite>("Image/SP5"));
        _Img.Add(6,Resources.Load<Sprite>("Image/SP6"));
        _Img.Add(7,Resources.Load<Sprite>("Image/SP7"));
        _Img.Add(8,Resources.Load<Sprite>("Image/SP8"));
        _Img.Add(9,Resources.Load<Sprite>("Image/SP9"));
        _Img.Add(10,Resources.Load<Sprite>("Image/SP10"));
    }
    public void SetImg()  //コールバック
    {
        int id = PlayerPrefs.GetInt("id");   //Iconを推した時にidがセットされたのをゲットする
        _StoryImg.sprite = _Img[id]; //Dictionaryのidをとる
        Debug.Log("SetImg;" + _Img[id]);
    }

    void onClickCancel()
    {
        Debug.Log("onClickCancel");
        this.gameObject.SetActive(false);
        _TLObj.SetActive(true);
        _StoryObj.SetActive(true);
    }
}
