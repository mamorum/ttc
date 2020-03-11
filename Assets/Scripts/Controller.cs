using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  internal readonly string none = "", x = "X", o = "O";
  internal readonly string draw = "It's a draw.",
    xwin = "X wins.", owin = "O wins";
  internal readonly Cpu cpu = new Cpu();
  public Cell[] cells; public Status status;
  public Restart restart; public Quit quit;
  public Play play; public Judge judge;
  public Canvas canvas;
  internal string turn;
  internal List<Cell> unclick = new List<Cell>();
  void Start() {
    cpu.Init(this); status.Init(this);
    for (int i = 0; i < cells.Length; i++) {
      cells[i].Init(this);
    }    
    restart.c = this; quit.c = this;
    play.c = this; judge.c = this;
    restart.Click();
  }
  void Update() {
    if (Paused()) return;
    if (cpu.Turn()) cpu.Process();
  }
  internal bool Paused() {
    return judge.gameObject.activeSelf
      || play.gameObject.activeSelf;
  }
  internal void ChangeTurn() {
    if (judge.Judged()) return;
    status.Next();
    if (turn == x) turn = o;
    else turn = x;
  }
}
