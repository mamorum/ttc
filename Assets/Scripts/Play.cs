using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {
  internal Controller c;
  void Cpu(string side) {
    gameObject.SetActive(false);
    c.cpu.Side(side);
    c.status.Cpu(side);
  }
  //-> X:User, O:CPU
  public void OnClickX() { Cpu(c.o); }
  //-> X:CPU, O:User
  public void OnClickO() { Cpu(c.x); }
}
