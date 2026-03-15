using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInteractable : MonoBehaviour
{
    public enum InteractableType
    {
        Collectable,
        Trap
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
            gameManager.BoxCollected();
        }
        gameObject.SetActive(false);
    }
}
