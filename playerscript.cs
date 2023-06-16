using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
   
    public logicscript logic;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.y < 5f)
        {
            logic.gameOver();
        }
    }
    public void start_game()
    {
        logic.bounce2();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bricks")
        {
            logic.bounce1();
        }
        
        else if(collision.collider.name=="blocker")
        {
            logic.bounce3();
        }
        else if(collision.collider.name=="blocker(1)")
        {
            logic.bounce4();
        }
    }
}
