using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Components
    private Rigidbody rigidBody;

    // Customizable Values
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        TakeInput();    
    }

    private void TakeInput()
    {
        // Space -> Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, (jumpPower * 100) * Time.deltaTime, 0f);
        }
        // A -> Go Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidBody.velocity = new Vector3((-speed * 100) * Time.deltaTime, rigidBody.velocity.y, 0f);
        }
        // D -> Go Right
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rigidBody.velocity = new Vector3 ((speed * 100) * Time.deltaTime, rigidBody.velocity.y, 0f);
        }
        else
        {

        }
    }
}
