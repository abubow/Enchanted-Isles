using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public ScoreManager scoreManager;
    public void Start()
    {
        // the objects containing the tag "ScoreManager" will be the score manager
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    public void Update()
    {
        // get the position of my first child and set it as the position of yourself
        transform.position = gameObject.transform.GetChild(0).transform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.name == "Player")
        {
            scoreManager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
