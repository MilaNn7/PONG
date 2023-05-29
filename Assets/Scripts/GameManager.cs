using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Move Player;
    public Move Computer;

    public Ball ball;

    private int playerScore;
    public Text playerScoreText;

    private int computerScore;
    public Text computerScoreText;


public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound(); 
    }
    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetRound();
    }
    private void ResetRound()
    {
        Computer.ResetPosition();
        Player.ResetPosition();
        ball.ResetPosition();
        ball.Sila();
    }
    
}
