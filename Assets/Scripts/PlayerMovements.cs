using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    public float speed;
    public float JumpForce;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f); 
        if(Input.GetKeyDown(KeyCode.Space)) Jump();
        
    }

    private void Jump() => Rigidbody2D.AddForce(Vector2.up * JumpForce);

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * speed, Rigidbody2D.velocity.y);
    }
}
