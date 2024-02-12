using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishLineManager : MonoBehaviour
{
    public int totalLaps = 3;
    private int currentLap = 0;
    public TextMeshProUGUI lapCounterText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentLap++;
            Debug.Log("Current Lap: " + currentLap + "/3");

            if (lapCounterText != null)
            {
                lapCounterText.text = "Lap: " + currentLap + "/" + totalLaps;
            }

            if (currentLap >= totalLaps)
            {
                Debug.Log("You Win");
                SceneManager.LoadSceneAsync("EndScreen");
            }
        }
    }
}
