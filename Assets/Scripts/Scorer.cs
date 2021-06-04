using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score;
    public void ScoreCal (int value)
    {
        score += value;
        print("The Score is " + score);
    }
}
