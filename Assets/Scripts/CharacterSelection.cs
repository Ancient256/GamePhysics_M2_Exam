using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

[System.Serializable]
public class CharacterStats
{
    public string name;
    public int health;
    public int speed;
    public int defense;
    public int mana;
}

public class CharacterSelection : MonoBehaviour
{
    [Header("Character Selection")]

    public GameObject[] characters;
    public int selectedCharacter = 0;



    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
     
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
       
    }

    
    



    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

}
