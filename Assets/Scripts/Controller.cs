using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  public Cell[] cells;
  void Start() {
    for (int i = 0; i < cells.Length; i++) {
      cells[i].id = i;
    }
  }
}
