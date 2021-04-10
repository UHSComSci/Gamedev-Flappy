using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float startingTime;
    public Transform pipePrefab;
    public float timeBetweenSpawn = 3;
    float countDown;

    public float minHeight = -4;
    public float maxHeight = 2.5f;

    public int points = 0;

    public Text scoreText;

    private void Start()
    {
        startingTime = Time.time;
        countDown = 0;
    }

    public float getElapsedTime()
    {
        return Time.time - startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if(countDown < 0)
        {
            countDown = timeBetweenSpawn;
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        Instantiate(pipePrefab, new Vector3(5.5f, Random.Range(minHeight, maxHeight)), Quaternion.Euler(0,0,0));
    }

    public void AddPoint()
    {
        points++;
        scoreText.text = points.ToString();
        //Display UI
    }
}
