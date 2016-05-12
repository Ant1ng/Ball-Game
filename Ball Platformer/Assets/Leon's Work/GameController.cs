using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	private int score;
	private int lives;

    public Text scoreText;
    public Text livesText;
	
	void Start ()
    {
        score = 0;
        lives = 3;
        SetScoreText();
        SetLivesText();
	}
	
	void Update ()
    {
	    
	}

    void addScore (int add)
    {
        score = score + add;
        SetScoreText();
    }

    void gainLives (int add)
    {
        lives = lives + add;
        SetLivesText();
    }
    
    void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }
    
    void SetLivesText()
    {
        livesText.text = "Lives: " + lives;
    }	
}
