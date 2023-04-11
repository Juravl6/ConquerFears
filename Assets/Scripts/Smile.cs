using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smile : MonoBehaviour
{
    ScoreCounter scoreCounter;
    SpriteRenderer spriteRenderer;
    public GameObject smile;

    private void Awake()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FearsChecker()
    {
        if (scoreCounter.fears < 4)
        {
            smile.SetActive(false);
        }
        if (scoreCounter.fears > 4)
        {
            smile.SetActive(true);
        }
    }
}
