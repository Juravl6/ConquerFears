using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int fears = 1;
    ScoreCounter scoreCounter;
    public AudioManager audioManager;

    private void Awake()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        scoreCounter.AddScore(fears);
        Destroy(gameObject);
        audioManager.PlayWinClip();
    }
}
