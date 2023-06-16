using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepadscript : MonoBehaviour
{
    public Rigidbody2D rb2;
    public float vel = 5f;
    public logicscript logic;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb2.velocity = Vector2.right * vel ;

        }
        else if (Input.GetKey("a"))
        {
            rb2.velocity = Vector2.left * vel;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.name == "player")
        {
            logic.bounce2();
        }
    }
}
