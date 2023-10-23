using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 20f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //gives it basic movements to dodge blocks
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector3 newPosition = rb.position + Vector3.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);

    }
}
