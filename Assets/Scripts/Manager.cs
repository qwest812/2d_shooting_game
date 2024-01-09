using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject winText;
    private bool win = false;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            CancelInvoke("Spawn");
        }

        if (Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play(); 
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(-8.5f, 8.5f);
        float randomY = Random.Range(-3f, 3f);
        Vector3 newPosition = new Vector3(randomX, randomY);
        Instantiate(target, newPosition, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score >= 10)
        {
            win = true;
            winText.SetActive(true);
        }
    }
}