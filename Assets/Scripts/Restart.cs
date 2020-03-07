using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
  internal Controller c;
  public void OnClick() {
    c.Play();
  }
}
