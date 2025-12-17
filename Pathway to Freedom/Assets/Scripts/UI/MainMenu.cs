using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject characterSelector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        characterSelector.SetActive(true);
    }

    public void SelectAssasin()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Assasin");
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

      public void SelectWarrior()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Warrior");
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

      public void SelectSwordsman()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Swordsman");
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
