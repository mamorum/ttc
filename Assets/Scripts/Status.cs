using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour {
  public GameObject[] arrows;
  public Text[] players;
  string player; string cpu;
  bool first;
  internal void Init() {
    gameObject.SetActive(false);
    player = players[0].text;
    cpu = players[1].text;
  }
  void Name(string first, string second) {
    players[0].text = first;
    players[1].text = second;
  }
  internal void First(bool isPlayer) {
    gameObject.SetActive(true);
    if (isPlayer) Name(player, cpu);
    else Name(cpu, player);
    first = true;
    Move();
  }
  void Move() {
    arrows[0].SetActive(first);
    arrows[1].SetActive(!first);
  }
  internal void Change() {
    first = !first;
    Move();
  }
}
