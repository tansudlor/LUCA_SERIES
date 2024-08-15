using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameShooting : MonoBehaviour
{

    public Text scoreTxt;

    public void ScoreUp(int score)
    {
        score += score;
        scoreTxt.text = score.ToString();
    }
}
