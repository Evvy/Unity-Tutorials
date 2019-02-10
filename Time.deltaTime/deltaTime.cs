using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime : MonoBehaviour {
  public float speed = 3.0f;
  
  public void Update() {
    transform.Translate(speed * Time.deltaTime, 0, 0);
  }
}
