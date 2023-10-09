    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// text mesh
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] public TextMeshProUGUI scoreLabel;
    public void IncreaseScore()
    {
        score++;
        scoreLabel.text = score.ToString();
    }
    public void DecreaseScore()
    {
        score--;
        scoreLabel.text = score.ToString();
    }
    public void Start()
    {
        score = 0;
    }
}
