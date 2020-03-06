using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Msg : MonoBehaviour {
  public Text txt;
  internal void On(string msg) {
    txt.text = msg;
    gameObject.SetActive(true);
  }
}
