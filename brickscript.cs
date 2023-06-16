using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickscript : MonoBehaviour
{
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            Destroy(gameObject);
            logic.Addscore();
        }
    }
}
