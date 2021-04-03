using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb2D;
    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb2D.velocity = Vector2.up * speed;
        }
        if(transform.position.y >= 4.65){
            rb2D.position = new Vector2(0,4.65f);
        }
    }
    void OnCollisionEnter2D(Collision2D colider) {
        gameOver.SetActive(true);  
        Time.timeScale = 0;      
    }
    
}
