using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    void Start() {
        controller = FindObjectOfType<GameController>();    
    }
    public GameController controller;
    void OnTriggerEnter2D(Collider2D colider) {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
