
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Pipes[] pipes;
    public Player player;
    public Text Score;
    public GameObject Button;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        Score.text = score.ToString();

        Button.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);    
        }


    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;

    }

    public void GameOver() 
    {
        gameOver.SetActive(true);
        Button.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        Score.text = score.ToString();
    }
}
