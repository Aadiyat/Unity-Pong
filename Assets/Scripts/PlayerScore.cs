using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    void Start(){
        scoreText.text= score.ToString();
    }

    public void incrementScore(){
        score++;
        scoreText.text = score.ToString();
    }

    public int getScore(){
        return score;
    }
}
