using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.SceneManagement;

public class AccountController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _Text = null;  //このテキストが各IDによって違う
    [SerializeField] private Image _Image = null; //このImageが各IDによって違う
    [SerializeField] private Button _BuckMainButton = null; //戻るボタン
     
    

    Dictionary<int,string> _NameText = new Dictionary<int, string>(); //UserNameのDic
    Dictionary<int,Sprite> _AcutImg = new Dictionary<int, Sprite>();  //AccountPageのImg
 
        void Start()
    {
        _BuckMainButton.onClick.AddListener(OnClickBuckMainButton);  //戻るボタンのイベント登録
         int id = PlayerPrefs.GetInt("id"); //PlayerPrefs のGetIntメゾット
        
        //Dictionary(UserName)
        _NameText.Add(1,"_Lisa");
        _NameText.Add(2,"_Selena");
        _NameText.Add(3,"_Jisoo");
        _NameText.Add(4,"_Rose");
        _NameText.Add(6,"_Jennie");
        _NameText.Add(7,"_twice");
        _NameText.Add(8,"_mamamoo");
        _NameText.Add(9,"_nijiu");
        _NameText.Add(10,"_Hwasa");

        //Dictionary(AccountPage)
        _AcutImg.Add(1,Resources.Load<Sprite>("Image/Account/Acut1"));
        _AcutImg.Add(2,Resources.Load<Sprite>("Image/Account/Acut2"));
        _AcutImg.Add(3,Resources.Load<Sprite>("Image/Account/Acut3"));
        _AcutImg.Add(4,Resources.Load<Sprite>("Image/Account/Acut4"));
        _AcutImg.Add(5,Resources.Load<Sprite>("Image/Account/Acut5"));
        _AcutImg.Add(6,Resources.Load<Sprite>("Image/Account/Acut6"));
        _AcutImg.Add(7,Resources.Load<Sprite>("Image/Account/Acut7"));
        _AcutImg.Add(8,Resources.Load<Sprite>("Image/Account/Acut8"));
        _AcutImg.Add(9,Resources.Load<Sprite>("Image/Account/Acut9"));
        _AcutImg.Add(10,Resources.Load<Sprite>("Image/Account/Acut10"));

         Debug.Log("id" + id);

        _Text.text = _NameText[id];
        _Image.sprite = _AcutImg[id];
        
        Debug.Log(_NameText[id]);

        Debug.Log(_AcutImg[id]);
        
    }
    void OnClickBuckMainButton()
    {
      SceneManager.LoadScene("MainScene");
      Debug.Log("OnClickBuckMainButton");
    }
}
