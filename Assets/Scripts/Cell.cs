using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {
  public Image img; public Text txt;
  public Color selected;
  internal int id;
  Controller c;
  internal void Init(Controller c, int id) {
    this.c = c; this.id = id;
    img = GetComponent<Image>();
    txt = GetComponentInChildren<Text>();
  }
  public void OnClick() {
    c.OnClick(this);
    c.ChangeSide();
  }
}