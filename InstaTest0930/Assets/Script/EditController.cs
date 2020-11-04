using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditController : MonoBehaviour
{
    [SerializeField] private GameObject _PostObj = null; //PostObj
    [SerializeField] private GameObject _TVObj = null; //TVObject
    [SerializeField] private GameObject _TagObj = null; //TagObject
    [SerializeField] private GameObject _EditObj = null;  //EditObj
    [SerializeField ] private Button _CancelButton = null; //CancelButton
    [SerializeField ] private Button _EditButton = null;

    
    void Start()
    {
        this.gameObject.SetActive(false);
        _EditButton.onClick.AddListener(OnClickEditButton);
        _CancelButton.onClick.AddListener(OnClickCancelButton);
        
    }

    void OnClickEditButton()
    {
        Debug.Log("Edit");
        _EditObj.SetActive(true);
        _PostObj.SetActive(false);
        _TVObj.SetActive(false);
        _TagObj.SetActive(false);

    }

    void OnClickCancelButton()
    {
        Debug.Log("Cancel");
        _EditObj.SetActive(false);
        _PostObj.SetActive(true);
        _TVObj.SetActive(true);
        _TagObj.SetActive(true);

    }
}
