using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int boxesCollected = 0;

    [SerializeField] TMP_Text scoreText;

    void Start()
    {
        updateScoreUI();
    }

    public void BoxCollected()
    {
        boxesCollected += 1;
        updateScoreUI();
    }

    void updateScoreUI()
    {
        scoreText.text = "Boxes collected: " + boxesCollected;
    }
}
