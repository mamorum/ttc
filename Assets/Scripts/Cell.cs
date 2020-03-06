using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {
  public Image img; public Text txt;
  public Color selected;
  Controller c;
  internal void Init(Controller c) {
    this.c = c;
  }
  public void OnClick() {
    if (txt.text != c.none) return;
    if (!c.playing) return;
    img.color = selected;
    txt.text = c.turn;
    c.ChangeTurn();
  }
}