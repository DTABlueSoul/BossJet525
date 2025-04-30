using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContractMenuController : MonoBehaviour
{

    public TMP_Text firstStatText;
    public TMP_Text secondStatText;
    public TMP_Text thirdStatText;

    public GameObject winPopup;

    public int firstStatGoal;
    public int secondStatGoal;
    public int thirdStatGoal;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();

        firstStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        thirdStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();

    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharacterMovement>().enabled = true;
    }

    public void SignButton()
    {
        if (playerStats.strength >= firstStatGoal
            && playerStats.strength >= secondStatGoal
            && playerStats.strength >= thirdStatGoal)
        {
            Debug.Log("All stat goals reached!!");
            winPopup.SetActive(true);
        }
    }
}
