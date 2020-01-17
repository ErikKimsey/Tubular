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
    roller = GetComponent<Rigidbody>();
      Physics.gravity = new Vector3(0, 1.0F, 0);
  }
  void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        roller.AddForce (movement * speed);
    }

}