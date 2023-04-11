using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int fears;
    public Text fearsText;
    public GameObject smile;
    public void AddScore(int addScore)
    {
        fears += addScore;
        fearsText.text = "Fears " + fears;
        FearsChecker();

    }
    public void FearsChecker()
    {
        if (fears < 4)
        {
            smile.SetActive(false);
        }
        if (fears > 4)
        {
            smile.SetActive(true);
        }
    }
}
