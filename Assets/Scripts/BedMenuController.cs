using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudyMenuController : MonoBehaviour
{
    public TMP_Text intelligenceText;

    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
        intelligenceText.text = playerStats.intelligence.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void TrainButton()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();

        playerStats.intelligence += 25;

        playerStats.timeLeft--;

        intelligenceText.text = playerStats.intelligence.ToString();


    }

}
