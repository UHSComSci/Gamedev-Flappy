using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void FixedUpdate()
    {
        float speed = -30 / (gameManager.getElapsedTime() + 15) + 3;
        transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0);
    }
}
