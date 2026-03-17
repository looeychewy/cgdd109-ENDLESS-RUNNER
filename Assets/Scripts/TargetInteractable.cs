using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInteractable : MonoBehaviour
{
    public enum InteractableType
    {
        Collectable,
        Rock,
        Wall,
        Cone
    }
    
    public InteractableType type;
    GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Trigger()
    {
        if(type == InteractableType.Collectable)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.boxPickup);
            gameManager.BoxCollected();
        }
        else if (type == InteractableType.Rock)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.rockDeath);
            gameManager.GameOver();
        }
        else if (type == InteractableType.Wall)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.wallDeath);
            gameManager.GameOver();
        }
        else if (type == InteractableType.Cone)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.coneDeath);
            gameManager.GameOver();
        }
        gameObject.SetActive(false);
    }
}
