using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  public Cell[] cells;
  internal readonly int empty = 0, x = 1, o = 2;
  int[] board; int turn;
  void Start() {
    for (int i = 0; i < cells.Length; i++) {
      cells[i].Init(this, i);
    }
    board = new int[cells.Length];
    ResetGame();
  }
  void ResetGame() {
    for (int i = 0; i < board.Length; i++) {
      board[i] = empty;
    }
    turn = x;
  }
  internal void OnClick(Cell c) {
    if (board[c.id] != empty) return;
    board[c.id] = turn;
    c.img.color = c.selected;
    if (turn == x) c.txt.text = "X";
    else c.txt.text = "O";
  }
  internal void ChangeSide() {
    // TODO: 終了判定
    if (turn == x) turn = o;
    else turn = x;
  }
}
