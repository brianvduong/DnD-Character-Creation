using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantManagerScript : MonoBehaviour
{
    public static PersistantManagerScript Instance { get; private set; }

    public string CharacterName;
    public float Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma;
    public string Race;
    public string Class;
    public string Allignment;
    public int CurrExp, MaxExp;
    public int CurrHP, MaxHP;
    public int ArmorClass;
    public int Walking, Running, JumpHeight;
    public List<string> ItemList;

    private void Awake()
    {
        if(Instance == null)    //means that this code has not been run yet
        {
            Instance = this;    //set it to contain this (cookie/cookie cutter metaphor)
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); //destroy duplicates
        }
    }
}
