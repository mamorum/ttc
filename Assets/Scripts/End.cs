using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {
  public Text judge;
  internal void Show(string msg) {
    judge.text = msg;
    gameObject.SetActive(true);
  }
}
