using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judgement : MonoBehaviour {
  public Text txt;
  internal void Show(string msg) {
    txt.text = msg;
    gameObject.SetActive(true);
  }
}
