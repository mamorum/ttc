using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour {
  public Image img; public Text txt;
  public Color click; Color unclick;
  Controller c;
  internal void Init(Controller ctrl) {
    c = ctrl;
    unclick = img.color;
  }
  internal void UnClick() {
    txt.text = c.none;
    img.color = unclick;
  }
  public void OnClick() {
    if (txt.text != c.none) return;
    if (!c.playing) return;
    img.color = click;
    txt.text = c.turn;
    c.ChangeTurn();
  }
}