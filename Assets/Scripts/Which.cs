using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Which : MonoBehaviour {
  internal Controller c;
  public void OnClickX() {
    gameObject.SetActive(false);
    c.Play(c.x);
  }
  public void OnClickO() {
    gameObject.SetActive(false);
    c.Play(c.o);
  }
}
