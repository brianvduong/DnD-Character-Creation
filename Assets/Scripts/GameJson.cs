using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameJson : MonoBehaviour
{
    public Text JSONText;

    public void Start()
    {
        JSONText.text = PersistantManagerScript.Instance.JSON;
    }

    public void Update()
    {
        JSONText.text = PersistantManagerScript.Instance.JSON;
    }

    public void setJSON()
    {
        PersistantManagerScript result = new PersistantManagerScript();
        result.CharacterName = PersistantManagerScript.Instance.CharacterName;
        result.Strength = PersistantManagerScript.Instance.Strength;
        result.Dexterity = PersistantManagerScript.Instance.Dexterity;
        result.Constitution = PersistantManagerScript.Instance.Constitution;
        result.Intelligence = PersistantManagerScript.Instance.Intelligence;
        result.Wisdom = PersistantManagerScript.Instance.Wisdom;
        result.Charisma = PersistantManagerScript.Instance.Charisma;
        result.Race = PersistantManagerScript.Instance.Race;
        result.Class = PersistantManagerScript.Instance.Class;
        result.Allignment = PersistantManagerScript.Instance.Allignment;
        result.CurrExp = PersistantManagerScript.Instance.CurrExp;
        result.MaxExp = PersistantManagerScript.Instance.MaxExp;
        result.CurrHP = PersistantManagerScript.Instance.CurrHP;
        result.MaxHP = PersistantManagerScript.Instance.MaxHP;
        result.ArmorClass = PersistantManagerScript.Instance.ArmorClass;
        result.Walking = PersistantManagerScript.Instance.Walking;
        result.Running = PersistantManagerScript.Instance.Running;
        result.JumpHeight = PersistantManagerScript.Instance.JumpHeight;
        string json = JsonUtility.ToJson(result);
        PersistantManagerScript.Instance.JSON = json;
    }
}
