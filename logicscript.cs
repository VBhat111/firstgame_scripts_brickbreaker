using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class logicscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedmin = 9f;
    public float speedmax = 10f;
    public GameObject gameover;
    public float a = 15f;
    public float b = 4f;
    public TextMeshProUGUI scoretext;
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
         
    
    public void bounce1()
    {
        rb.velocity = new Vector2(Random.Range(-b,b), Random.Range(-b, a));
    }
    public void bounce2()
    {
        rb.velocity = new Vector2(Random.Range(-b, b), Random.Range(speedmin, speedmax));
    }
    public void bounce3()
    {
        rb.velocity = new Vector2(Random.Range(b,1f), Random.Range(-b, a));
    }
    public void bounce4()
    {
        rb.velocity = new Vector2(Random.Range(-b, -1f), Random.Range(-b, a));
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameover.SetActive(true);
    }
    public void Addscore()
    {
        score = score + 1;
        scoretext.text = score.ToString();
    }
   
}
