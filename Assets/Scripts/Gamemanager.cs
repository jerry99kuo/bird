using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public Player player ;
    public TextMeshProUGUI  scoreText ;
    public GameObject playbutton ;
    public GameObject gameOver ;

    private void Awake() {
        Application.targetFrameRate = 60 ;

        Pause() ;
    }
    public void Play ()
    {
        score = 0 ;
        scoreText.text = score.ToString();

        playbutton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f ;
        player.enabled = true ;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0 ; i < pipes.Length ; ++ i ){
            Destroy(pipes[i].gameObject) ;
        }
    }
    public void Pause() 
    {
        Time.timeScale = 0f ;
        player.enabled = false ;
    }

    private int score ;

    public void GameOver()
    {
        gameObject.SetActive(true);
        playbutton.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score ++ ;
        scoreText.text = score.ToString();
    }
}
