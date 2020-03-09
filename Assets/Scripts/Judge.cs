using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judge : MonoBehaviour {
  public Text txt;
  internal Controller c;
  bool Eq(int i, int ii, int iii) {
    return c.cells[iii].txt.text == c.turn
      && c.cells[ii].txt.text == c.turn
      && c.cells[i].txt.text == c.turn;
  }
  bool IsWin() {
    return // vertical:3, horizontal:3, diagonal:2
      Eq(0, 1, 2) || Eq(3, 4, 5) || Eq(6, 7, 8) ||
      Eq(0, 3, 6) || Eq(1, 4, 7) || Eq(2, 5, 8) ||
      Eq(0, 4, 8) || Eq(2, 4, 6);
  }
  void Win() {
    if (c.turn == c.x) txt.text = c.xwin;
    else txt.text = c.owin;
    gameObject.SetActive(true);
  }
  bool IsDraw() {
    return c.unclick.Count == 0;
  }
  void Draw() {
    txt.text = c.draw;
    gameObject.SetActive(true);
  }
  internal bool Judged() {
    if (IsWin()) Win();
    else if (IsDraw()) Draw();
    else return false;
    //-> win or draw
    return true;
  }
}
