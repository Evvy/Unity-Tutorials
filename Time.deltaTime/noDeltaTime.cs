using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDeltaTime : MonoBehaviour {
  public float speed = 3.0f;
  
  public void Update() {
    transform.Translate(speed, 0, 0);
  }
}
