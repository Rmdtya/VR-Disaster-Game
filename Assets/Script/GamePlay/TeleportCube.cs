using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCube : MonoBehaviour
{
    public GameManager gameManager;

    public string nextScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            gameManager.ChangeScene(nextScene);
        }
    }
}
