using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public GameObject MainCamera;
    private GameObject player;
    private int cameraPosition = 0;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            enemy.SetActive(true);
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            cameraPosition += 11;

            MainCamera.transform.position = new Vector3(0, cameraPosition, -10);
        }
    }
}
