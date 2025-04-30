using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FridgeMenuController : MonoBehaviour
{
    public TMP_Text techniqueText;

    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitMenu()
        {
            gameObject.SetActive(false);
        }

    public void TrainButton()
        {
            PlayerStats playerStats = FindAnyObjectByType<PlayerStats>();

            playerStats.health += 25;
            playerStats.strength -= 10;
            playerStats.timeLeft--;

            techniqueText.text = playerStats.technique.ToString();
        }
}
