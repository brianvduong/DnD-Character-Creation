using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text CharacterNameText;
    public Text StrengthText, DexterityText, ConstitutionText, IntelligenceText, WisdomText, CharismaText;
    public Text RaceText;
    public Text ClassText;
    public Text AllignmentText;
    public Text CurrExpText, MaxExpText;
    public Text CurrHPText, MaxHPText;
    public Text ArmorClassText;
    public Text WalkingText, RunningText, JumpHeightText;
    public Text ItemListText;

    public void Start()
    {
        CharacterNameText.text = PersistantManagerScript.Instance.CharacterName;
        StrengthText.text = PersistantManagerScript.Instance.Strength.ToString();
        DexterityText.text = PersistantManagerScript.Instance.Dexterity.ToString();
        ConstitutionText.text = PersistantManagerScript.Instance.Constitution.ToString();
        IntelligenceText.text = PersistantManagerScript.Instance.Intelligence.ToString();
        WisdomText.text = PersistantManagerScript.Instance.Wisdom.ToString();
        CharismaText.text = PersistantManagerScript.Instance.Charisma.ToString();
        RaceText.text = PersistantManagerScript.Instance.Race;
        ClassText.text = PersistantManagerScript.Instance.Class;
        AllignmentText.text = PersistantManagerScript.Instance.Allignment;
        CurrExpText.text = PersistantManagerScript.Instance.CurrExp.ToString();
        MaxExpText.text = PersistantManagerScript.Instance.MaxExp.ToString();
        CurrHPText.text = PersistantManagerScript.Instance.CurrHP.ToString();
        MaxHPText.text = PersistantManagerScript.Instance.MaxHP.ToString();
        ArmorClassText.text = PersistantManagerScript.Instance.ArmorClass.ToString();
        WalkingText.text = PersistantManagerScript.Instance.Walking.ToString();
        RunningText.text = PersistantManagerScript.Instance.Running.ToString();
        JumpHeightText.text = PersistantManagerScript.Instance.JumpHeight.ToString();
    }

    public void Update()
    {
        CharacterNameText.text = PersistantManagerScript.Instance.CharacterName;
        StrengthText.text = PersistantManagerScript.Instance.Strength.ToString();
        DexterityText.text = PersistantManagerScript.Instance.Dexterity.ToString();
        ConstitutionText.text = PersistantManagerScript.Instance.Constitution.ToString();
        IntelligenceText.text = PersistantManagerScript.Instance.Intelligence.ToString();
        WisdomText.text = PersistantManagerScript.Instance.Wisdom.ToString();
        CharismaText.text = PersistantManagerScript.Instance.Charisma.ToString();
        RaceText.text = PersistantManagerScript.Instance.Race;
        ClassText.text = PersistantManagerScript.Instance.Class;
        AllignmentText.text = PersistantManagerScript.Instance.Allignment;
        CurrExpText.text = PersistantManagerScript.Instance.CurrExp.ToString();
        MaxExpText.text = PersistantManagerScript.Instance.MaxExp.ToString();
        CurrHPText.text = PersistantManagerScript.Instance.CurrHP.ToString();
        MaxHPText.text = PersistantManagerScript.Instance.MaxHP.ToString();
        ArmorClassText.text = PersistantManagerScript.Instance.ArmorClass.ToString();
        WalkingText.text = PersistantManagerScript.Instance.Walking.ToString();
        RunningText.text = PersistantManagerScript.Instance.Running.ToString();
        JumpHeightText.text = PersistantManagerScript.Instance.JumpHeight.ToString();
    }

    public int largest3(int[] d6s)
    {
        int first, second, third, sum;
        first = second = third = 0;
        for (int i = 0; i < 5; i++)
        {
            if (d6s[i] > first)
            {
                third = second;
                second = first;
                first = d6s[i];
            }
            else if (d6s[i] > second)
            {
                third = second;
                second = d6s[i];
            }
            else if (d6s[i] > third)
            {
                third = d6s[i];
            }
        }
        sum = first + second + third;
        return sum;
    }

    public int[] roll5d6()
    {
        int[] d6s = new int[5];
        System.Random rnd = new System.Random();
        for (int i = 0; i < 5; i++)
        {
            int die = rnd.Next(1, 6);
            d6s[i] = die;
        }
        return d6s;
    }

    public int result()
    {
        int modifier = 2;
        int sum = largest3(roll5d6());
        return sum + modifier;
    }

    public void rollStrength()
    {
        PersistantManagerScript.Instance.Strength = result();
    }

    public void rollDexterity()
    {
        PersistantManagerScript.Instance.Dexterity = result();
    }

    public void rollConstitution()
    {
        PersistantManagerScript.Instance.Constitution = result();
    }

    public void rollIntelligence()
    {
        PersistantManagerScript.Instance.Intelligence = result();
    }

    public void rollWisdom()
    {
        PersistantManagerScript.Instance.Wisdom = result();
    }

    public void rollCharisma()
    {
        PersistantManagerScript.Instance.Charisma = result();
    }

    public void generateExp()
    {
        PersistantManagerScript.Instance.CurrExp = 0;
        PersistantManagerScript.Instance.MaxExp = 300;
    }

    public void generateHP()
    {
        PersistantManagerScript.Instance.CurrHP = 8;
        PersistantManagerScript.Instance.MaxHP = 8;
    }

    public void generateSpeed()
    {
        PersistantManagerScript.Instance.Walking = 30;
        PersistantManagerScript.Instance.Running = 50;
        PersistantManagerScript.Instance.JumpHeight = 10;
    }

    public void setClass()
    {
        int value = GameObject.Find("Class Dropdown").GetComponent<Dropdown>().value;
        if (value == 0) { PersistantManagerScript.Instance.Class = "Barbarian"; }
        if (value == 1) { PersistantManagerScript.Instance.Class = "Bard"; }
        if (value == 2) { PersistantManagerScript.Instance.Class = "Cleric"; }
        if (value == 3) { PersistantManagerScript.Instance.Class = "Druid"; }
        if (value == 4) { PersistantManagerScript.Instance.Class = "Fighter"; }
        if (value == 5) { PersistantManagerScript.Instance.Class = "Monk"; }
        if (value == 6) { PersistantManagerScript.Instance.Class = "Paladin"; }
        if (value == 7) { PersistantManagerScript.Instance.Class = "Ranger"; }
        if (value == 8) { PersistantManagerScript.Instance.Class = "Rogue"; }
        if (value == 9) { PersistantManagerScript.Instance.Class = "Sorcerer"; }
        if (value == 10) { PersistantManagerScript.Instance.Class = "Warlock"; }
        if (value == 11) { PersistantManagerScript.Instance.Class = "Wizard"; }
    }

    public void setRace()
    {
        int value = GameObject.Find("Race Dropdown").GetComponent<Dropdown>().value;
        if (value == 0) { PersistantManagerScript.Instance.Race = "Dragonborn"; }
        if (value == 1) { PersistantManagerScript.Instance.Race = "Dwarf"; }
        if (value == 2) { PersistantManagerScript.Instance.Race = "Elf"; }
        if (value == 3) { PersistantManagerScript.Instance.Race = "Gnome"; }
        if (value == 4) { PersistantManagerScript.Instance.Race = "Half-Elf"; }
        if (value == 5) { PersistantManagerScript.Instance.Race = "Half-Orc"; }
        if (value == 6) { PersistantManagerScript.Instance.Race = "Halfing"; }
        if (value == 7) { PersistantManagerScript.Instance.Race = "Human"; }
        if (value == 8) { PersistantManagerScript.Instance.Race = "Tiefling"; }
    }

    public void setAllignment()
    {
        int value = GameObject.Find("Allignment Dropdown").GetComponent<Dropdown>().value;
        if (value == 0) { PersistantManagerScript.Instance.Allignment = "Lawful Good"; }
        if (value == 1) { PersistantManagerScript.Instance.Allignment = "Neutral Good"; }
        if (value == 2) { PersistantManagerScript.Instance.Allignment = "Chaotic Good"; }
        if (value == 3) { PersistantManagerScript.Instance.Allignment = "Lawful Neutral"; }
        if (value == 4) { PersistantManagerScript.Instance.Allignment = "True Neutral"; }
        if (value == 5) { PersistantManagerScript.Instance.Allignment = "Chaotic Neutral"; }
        if (value == 6) { PersistantManagerScript.Instance.Allignment = "Lawful Evil"; }
        if (value == 7) { PersistantManagerScript.Instance.Allignment = "Neutral Evil"; }
        if (value == 8) { PersistantManagerScript.Instance.Allignment = "Chaotic Evil"; }
    }

    public void setName()
    {
        string name = GameObject.Find("Name Input").GetComponent<InputField>().text;
        PersistantManagerScript.Instance.CharacterName = name;
    }

    public void setArmor()
    {
        string armor = GameObject.Find("Armor Class Input").GetComponent<InputField>().text;
        PersistantManagerScript.Instance.ArmorClass = int.Parse(armor);
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
