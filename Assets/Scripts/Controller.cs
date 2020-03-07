using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  public Cell[] cells;
  public Restart restart;
  public End end;
  internal readonly string
    none = "", x = "X", o = "O";
  internal readonly string
    xwin = "X wins.", owin = "O wins",
    draw = "It's a draw.";
  internal string turn;
  internal bool playing;
  internal int click;
  void Start() {
    for (int i = 0; i < cells.Length; i++) {
      cells[i].Init(this);
    }
    restart.c = this;
    Play();
  }
  internal void Play() {
    for (int i = 0; i < cells.Length; i++) {
      cells[i].UnClick();
    }
    end.gameObject.SetActive(false);
    // TODO: 先手後手の選択
    playing = true;
    click = 0;
    turn = x;
  }
  bool Eq(int i, int ii, int iii) {
    return cells[iii].txt.text == turn
      && cells[ii].txt.text == turn
      && cells[i].txt.text == turn;
  }
  bool IsWin() {
    return // vertical:3, horizontal:3, diagonal:2
      Eq(0, 1, 2) || Eq(3, 4, 5) || Eq(6, 7, 8) ||
      Eq(0, 3, 6) || Eq(1, 4, 7) || Eq(2, 5, 8) ||
      Eq(0, 4, 8) || Eq(2, 4, 6);
  }
  bool IsDraw() {
    return click == cells.Length;
  }
  void Win() {
    if (turn == x) end.Show(xwin);
    else end.Show(owin);
    playing = false;
  }
  void Draw() {
    end.Show(draw);
    playing = false;
  }
  internal void ChangeTurn() {
    click++;
    //-> judge
    if (IsWin()) { Win(); return; }
    if (IsDraw()) { Draw(); return; }
    //-> change
    if (turn == x) turn = o;
    else turn = x;
  }
}
