using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSscript : MonoBehaviour
{

    public static GameSscript instance;
    public UnityEngine.UI.Text scoreLabel;
    
    private float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreLabel.gameObject.SetActive(false);
        
    }
    public void increaseScore(int increment)
    {
        score += increment;
        scoreLabel.text = "Score: " + score;
        scoreLabel.gameObject.SetActive(true);

    }

}
