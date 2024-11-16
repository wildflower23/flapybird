using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject gameoverscreen;
    
    [ContextMenu("Increment Score")]
    public void addScore(int scoretoadd)
    {
        playerScore = playerScore + scoretoadd ;
        ScoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameoverscreen.SetActive(true);
    }
}
