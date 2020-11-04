using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PostPrefabController : MonoBehaviour
{
    [SerializeField] private Image _PostImage = null;
    
    
    public void SetPrefab(Sprite sprite)
    {
        _PostImage.sprite = sprite;
    }
}
