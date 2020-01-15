using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerController : MonoBehaviour {


  float moveHorizontal;
  float moveVertical;

  public float speed = 50.0f;

  Vector3 movement;

  Rigidbody roller;

  private void Start() {
    moveHorizontal = Input.GetAxis("Horizontal");
    moveVertical = Input.GetAxis("Vertical");
    roller = GetComponent<Rigidbody>();
    movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
  }
  private void FixedUpdate() {
    transform.position += Vector3.forward * Time.deltaTime * speed;
  }

}