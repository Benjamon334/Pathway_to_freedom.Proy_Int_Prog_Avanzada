using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject boss;
    public GameObject MainCamera;
    private GameObject player;
    private int cameraPosition = 11;


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
            boss.SetActive(true);
            cameraPosition += 11;

            MainCamera.transform.position = new Vector3(0, cameraPosition, -10);
        }
    }
}
