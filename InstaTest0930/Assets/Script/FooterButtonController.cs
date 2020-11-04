using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FooterButtonController : MonoBehaviour
{
    [SerializeField] private Button _HomeButton = null;
    [SerializeField] private Button _SerchButton = null;
    [SerializeField] private Button _NewPostButton = null;
    [SerializeField] private Button _ActionButton = null;
    [SerializeField] private Button _AccountButton = null;
    


    void Start()
    {
        _HomeButton.onClick.AddListener(OnClickHome);
        _SerchButton.onClick.AddListener(OnClickSerch);
        _NewPostButton.onClick.AddListener(OnClickNewPost);
        _ActionButton.onClick.AddListener(OnClickAction);
        _AccountButton.onClick.AddListener(OnClickAccount);
        
    }
    void OnClickHome()
    {
        Debug.Log("HomeButton");
        SceneManager.LoadScene("TLScene");
    }

    void OnClickSerch()
    {
        Debug.Log("SerchButton");
        SceneManager.LoadScene("SerchScene");
    }
    void OnClickNewPost()
    {
        Debug.Log("NewPostButton");
        SceneManager.LoadScene("NewPostScene");
    }
    void OnClickAction()
    {
        Debug.Log("ActionButton");
        SceneManager.LoadScene("ActionScene");
    }

    void OnClickAccount()
    {
        Debug.Log("AccountButton");
        SceneManager.LoadScene("MyAccountScene");
    }
}
