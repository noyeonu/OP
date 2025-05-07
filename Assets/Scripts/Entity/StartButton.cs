using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void backGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
