using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBoardRegion : MonoBehaviour
{
    public GameManager gameManager;
    public int region;
    public int multiplier;
    private int totalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRayHit()
    {
        totalScore = region * multiplier;
        gameManager.ScoreUpdater(totalScore);
        Debug.Log("Raycast Works");
    }
}
