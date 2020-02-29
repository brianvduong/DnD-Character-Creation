using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class playable : MonoBehaviour
{
    public void startGame()
    {
        if (PersistantManagerScript.Instance.Strength == 0)
        {
            GameObject.Find("play button").GetComponent<Button>().interactable = false;
        }
        else
        {
            GameObject.Find("play button").GetComponent<Button>().interactable = true;
            SceneManager.LoadScene("Game");
        }
    }
}
