using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrefabController : MonoBehaviour
{
    public Image _StoryIcon;
    // public Image _TLIcon;
    // public Image _MainImage;
    // public Image _TLHert;
    // public Image _TLComment;
    // public Image _TLShare;
    // public Image _TLSave;
    //public Text _UserName;
    
    public void SetStorySprite(Sprite sprite)
    {
        _StoryIcon.sprite = sprite;
    }

    // public void SetTLSprite(Sprite sprite)
    // {
    //     _TLIcon.sprite = sprite;
    //     _MainImage.sprite = sprite;
    //     _TLHert.sprite = sprite;
    //     _TLComment.sprite = sprite;
    //     _TLShare.sprite = sprite;
    //     _TLSave.sprite = sprite;
    // }

    // public void SetUserName(string text)
    // {
    //     _UserName.text = text;
    // }
}
