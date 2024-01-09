using System;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] private Manager gameManager;
    
    private void Start()
    {
        
        gameManager = GameObject.Find("GameManager").GetComponent<Manager>();
        Destroy(gameObject, 2f);
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
}
