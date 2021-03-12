using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 301;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUpdater(int subtract)
    {
        score -= subtract;
        scoreText.text = "Score: " + score;
    }
}
