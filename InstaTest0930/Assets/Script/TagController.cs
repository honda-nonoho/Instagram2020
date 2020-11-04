using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TagController : MonoBehaviour
{
    [SerializeField] private GameObject _PostObj = null; //PostObj
    [SerializeField] private GameObject _TVObj = null; //TVObject
    [SerializeField] private GameObject _TagObj = null; //TagObject
    [SerializeField] private GameObject _EditObj = null;  //EditObj
    [SerializeField ] private Button _TagButton = null; //CancelButton
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        _TagButton.onClick.AddListener(OnClickTagButton);
        
    }

    void OnClickTagButton()
    {
        Debug.Log("Tag");
        
         _TagObj.SetActive(true);
        _PostObj.SetActive(false);
        _TVObj.SetActive(false);
        _EditObj.SetActive(false);

    }
}
