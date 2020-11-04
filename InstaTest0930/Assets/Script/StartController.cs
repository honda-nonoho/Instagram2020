using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Global;
public class StartController : MonoBehaviour
{

    void Awake()
    {
        var globalObject = Resources.Load<GlobalController>("Prefab/GlobalController");
        var gameObject = Instantiate<GlobalController>(globalObject , Vector3.zero, Quaternion.identity);

        DontDestroyOnLoad(gameObject);

    }
    void Start()
    {
         SceneManager.LoadScene("TLScene");
    }

}
