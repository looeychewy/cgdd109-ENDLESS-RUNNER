using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int boxesCollected = 0;
    //public UnityEvent onPlay = new UnityEvent();
    int highScore = 0;

    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
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

        if (boxesCollected % 10 == 0)
            StartCoroutine(FlashMilestone());
    }

    IEnumerator FlashMilestone()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.milestone);
        for (int i = 0; i < 10; i++)
        {
            scoreText.gameObject.SetActive(!scoreText.gameObject.activeSelf);
            yield return new WaitForSeconds(0.20f);
        }

        scoreText.gameObject.SetActive(true);
        updateScoreUI();
    }

    public void GameOver()
    {
        StartCoroutine(CameraShake.Instance.Shake(0.4f, 0.15f));
        AudioManager.Instance.PauseBGMusic();

        if (boxesCollected > highScore)
        {
            highScore = boxesCollected;
        }

        highScoreText.text = "High Score: " + highScore;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        AudioManager.Instance.PlayBGMusic(true, null);
        
        InteractableSpawner.currentSpeed = 5f;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void updateScoreUI()
    {
        scoreText.text = "Boxes collected: " + boxesCollected;
    }
}
