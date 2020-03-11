using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
  internal Controller c;
  public void OnClick() { Click(); }
  internal void Click() {
    //-> reset
    c.unclick.Clear();
    for (int i = 0; i < c.cells.Length; i++) {
      c.unclick.Add(c.cells[i]);
      c.cells[i].UnClick();
    }
    c.turn = c.x;
    //-> message
    c.status.gameObject.SetActive(false);
    c.judge.gameObject.SetActive(false);
    c.play.gameObject.SetActive(true);
  }
}
