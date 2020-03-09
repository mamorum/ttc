using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpu {
  Controller c;
  string side;
  int wait; // frame
  readonly int _wait = 20; // frame
  internal void Init(Controller c) {
    this.c = c;
    Application.targetFrameRate = 60;
  }
  internal bool Turn() {
    return side == c.turn;
  }
  internal void Side(string side) {
    this.side = side;
    wait = _wait;
  }
  internal void Process() {
    //-> delay
    wait--;
    if (wait != 0) return;
    else wait = _wait;
    //-> click cell
    int i = Random.Range(
      0, c.unclick.Count
    );
    c.unclick[i].Click();
  }
}
