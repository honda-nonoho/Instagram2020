using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour {

  [SerializeField] private GameObject _PostObj = null; //PostObj
  [SerializeField] private GameObject _TVObj = null; //TVObject
  [SerializeField] private GameObject _TagObj = null; //TagObject
  [SerializeField] private GameObject _EditObj = null;  //EditObj

  //オブジェクトと結びつける
  public InputField NameInputField;
  public Text NameText;
  public InputField UserNameInputField;
  public Text UserNameText;
  public InputField SelfIntrInputField;
  public Text SelfIntrText;
  
  [SerializeField ] private Button _DoneButton = null; //DoneButton

  void Start () {

    _DoneButton.onClick.AddListener(OnClickDone);
    //Componentを扱えるようにする
      NameInputField = NameInputField.GetComponent<InputField> ();
      NameText = NameText.GetComponent<Text> ();
      UserNameInputField = UserNameInputField.GetComponent<InputField> ();
      UserNameText = UserNameText.GetComponent<Text> ();
      SelfIntrInputField = SelfIntrInputField.GetComponent<InputField> ();
      SelfIntrText = SelfIntrText.GetComponent<Text> ();

    }

    void OnClickDone()
    {
      InputText();
      _PostObj.SetActive(true);
      _EditObj.SetActive(false);
      _TVObj.SetActive(false);
      _TagObj.SetActive(false);
    }
     void InputText(){
        //テキストにinputFieldの内容を反映
         NameText.text = NameInputField.text;
         UserNameText.text = UserNameInputField.text;
         SelfIntrText.text = SelfIntrInputField.text;

     }

}
