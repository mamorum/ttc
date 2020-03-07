using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  public Cell[] cells;
  public Restart restart;
  public Which which;
  public Judgement judge;
  internal readonly string
    none = "", x = "X", o = "O";
  internal readonly string
    xwin = "X wins.", owin = "O wins",
    draw = "It's a draw.";
  internal string turn; internal bool playing;
  internal bool isCpu; Cpu cpu = new Cpu();
  internal List<Cell> unclick = new List<Cell>();
  int frm; int wait = 20;
  void Update() {
    if (!playing) return;
    if (!isCpu) return;
    if (frm == wait) cpu.Click();
    else frm++;
  }
  void Start() {
    playing = false;
    for (int i = 0; i < cells.Length; i++) {
      cells[i].Init(this);
    }
    restart.c = this;
    which.c = this;
    cpu.c = this;
    Restart();
  }
  internal void Restart() {
    //-> reset
    unclick.Clear();
    for (int i = 0; i < cells.Length; i++) {
      unclick.Add(cells[i]);
      cells[i].UnClick();
    }
    turn = x;
    frm = 0;
    //-> message
    judge.gameObject.SetActive(false);
    which.gameObject.SetActive(true);
  }
  internal void Play(string side) {
    playing = true;
    if (side == x) isCpu = false;
    else isCpu = true;
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
    return unclick.Count == 0;
  }
  void Win() {
    if (turn == x) judge.Show(xwin);
    else judge.Show(owin);
    playing = false;
  }
  void Draw() {
    judge.Show(draw);
    playing = false;
  }
  internal void ChangeTurn() {
    //-> judge
    if (IsWin()) { Win(); return; }
    if (IsDraw()) { Draw(); return; }
    //-> change
    if (turn == x) turn = o;
    else turn = x;
    //-> cpu
    isCpu = !isCpu;
    if (isCpu) frm = 0;
  }
}
