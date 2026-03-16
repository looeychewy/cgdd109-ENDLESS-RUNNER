using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int boxesCollected = 0;
    //public UnityEvent onPlay = new UnityEvent();

    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject gameOverPanel;


    void Start()
    {
        gameOverPanel.SetActive(false);
        updateScoreUI();
    }

    /*public void StartGame()
    {
        onPlay.Invoke();
        isPlaying = true;
    }*/

    public void BoxCollected()
    {
        boxesCollected += 1;
        updateScoreUI();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void updateScoreUI()
    {
        scoreText.text = "Boxes collected: " + boxesCollected;
    }
}
