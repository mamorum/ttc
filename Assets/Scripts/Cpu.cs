using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpu {
  internal Controller c;
  internal void Click() {
    int i = Random.Range(
      0, c.unclick.Count
    );
    c.unclick[i].OnClick();
  }
}
