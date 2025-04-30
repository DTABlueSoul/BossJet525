using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public TMP_Text text;
    public string user = "Damian Wayne";
    public int strength = 1000;
    public int technique = 99;
    public int speed = 50;
    public int health = 1000000;
    public int stamina = 50;
    public int timeLeft = 1;
    public int intelligence = 2400;

    // Start is called before the first frame update
    void Start()
    {
        MyFunction();
        MyFunction();
        technique++;
        
    }

    // Update is called once per frame
    void Update()

    {
       
    }
            void MyFunction()
    {
        Debug.Log("I HATE EEEEEEEEEEVVVVVVVVVVVAAAAAA");
        Debug.Log("Demoni!!!!!! Clean up on aisle 6");
        Debug.Log("Joker: theres no srule to the pokemon, Ima do it Ima weeeeee");
    }
    }   

    

