using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoryPageController : MonoBehaviour
{
    public int id;
    //表示したいobj
    [SerializeField] private GameObject _StoryPageObj = null;
    //非表示したいobj
    [SerializeField] private GameObject _TLStoryObj = null;
    [SerializeField] private GameObject _TLObj = null;
    [SerializeField] private Image _Image = null; //このImageが各IDによって違う
    [SerializeField] private Button _BuckMainButton = null; //戻るボタン

    Dictionary<int,Sprite> _StoryImg = new Dictionary<int, Sprite>();


 
    
    
    
    void Start()
    {
        this.gameObject.SetActive(false);
        _BuckMainButton.onClick.AddListener(OnClickBuckMainButton); 

        _StoryImg.Add(1,Resources.Load<Sprite>("Image/SP1"));
        _StoryImg.Add(2,Resources.Load<Sprite>("Image/SP2"));                
        _StoryImg.Add(3,Resources.Load<Sprite>("Image/SP3"));        
        _StoryImg.Add(4,Resources.Load<Sprite>("Image/SP4"));        
        _StoryImg.Add(5,Resources.Load<Sprite>("Image/SP5"));        
        _StoryImg.Add(6,Resources.Load<Sprite>("Image/SP6"));        
        _StoryImg.Add(7,Resources.Load<Sprite>("Image/SP7"));        
        _StoryImg.Add(8,Resources.Load<Sprite>("Image/SP8"));        
        _StoryImg.Add(9,Resources.Load<Sprite>("Image/SP9"));  
        _StoryImg.Add(10,Resources.Load<Sprite>("Image/SP10"));  

       
    }
    public void SetImg()
    { 
            int id = PlayerPrefs.GetInt("id");    
            _Image.sprite = _StoryImg[id];
            Debug.Log("SetImg: " + _StoryImg[id]);
    }
    void OnClickBuckMainButton()
    {
      Debug.Log("OnClickBuckMainButton");
      this.gameObject.SetActive(false);
      _TLStoryObj.SetActive(true);
      _TLObj.SetActive(true);

    }
}
