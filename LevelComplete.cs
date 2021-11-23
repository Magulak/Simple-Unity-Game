
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }
}

