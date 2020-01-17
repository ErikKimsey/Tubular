using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject roller;
  private Vector3 offset;

    void Start()
    {
      offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = roller.transform.position;
      Vector3 direction = (roller.transform.position - transform.position).normalized;
      Quaternion look = Quaternion.LookRotation(direction);
      transform.rotation = look;
    }
}
