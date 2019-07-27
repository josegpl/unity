using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 3.0f;
    Rigidbody rbody;
    public new GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = Vector3.zero;
        rbody.angularVelocity = Vector3.zero;

         
          if (Input.GetKeyDown("space"))
            {
  transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
          }
 

    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            var t = camera.transform;
            rbody.MovePosition(transform.position + t.forward * Time.deltaTime * speed);
        }

    }
}