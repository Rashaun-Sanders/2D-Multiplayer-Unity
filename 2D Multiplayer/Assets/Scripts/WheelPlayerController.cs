using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;

    private Rigidbody2D _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movemet = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movemet, 0, 0) * Time.deltaTime * movementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
