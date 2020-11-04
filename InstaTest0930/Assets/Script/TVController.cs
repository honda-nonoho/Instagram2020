using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVController : MonoBehaviour
{
    [SerializeField] private GameObject _PostObj = null; //PostObj
    [SerializeField] private GameObject _TVObj = null; //TVObject
    [SerializeField] private GameObject _TagObj = null; //TagObject
    [SerializeField] private GameObject _EditObj = null;  //EditObj
    [SerializeField ] private Button _TVButton = null; //CancelButton
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
         _TVButton.onClick.AddListener(OnClickTVButton);
    }

    void OnClickTVButton()
    {
        Debug.Log("TV");
        
        _TVObj.SetActive(true);
         _TagObj.SetActive(false);
        _PostObj.SetActive(false);
        _EditObj.SetActive(false);

    }
}
