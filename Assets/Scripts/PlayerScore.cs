using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;

    public void incrementScore(){
        score++;
    }

    public int getScore(){
        return score;
    }
}
