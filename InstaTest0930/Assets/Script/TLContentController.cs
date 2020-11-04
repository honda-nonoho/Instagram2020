using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TLContentController : MonoBehaviour
{
    [SerializeField] private Image _TLImage = null;
    [SerializeField] private Image _IconImage = null;
    [SerializeField] private Text _UserName = null;
    
    public Sprite Hert; //いいねの押す前
    public Sprite OnClickHert; //いいね押した後
    private bool change = false;  //ボタンを押したら戻る、の宣言

     public void SetPrefab(string UnText,Sprite sprite,Sprite IconSprite)
    {
        //Debug.Log(UnText,sprite,IconSprite);
        _UserName.text = UnText;
         _TLImage.sprite = sprite;
        _IconImage.sprite = IconSprite;

    }

     public void OnClickFav()  //ボタンを押した時の処理
    {
        if(!change)
        {
            this.gameObject.GetComponent<Image> ().sprite = OnClickHert; //押したら画像が変わる処理
            change = true;
        }else{
            this.gameObject.GetComponent<Image> ().sprite = Hert;  //もう一回押したら戻る
            change = false;
        }
    }
}
