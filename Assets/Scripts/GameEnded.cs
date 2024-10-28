using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameEnded : MonoBehaviour
{
    public static bool GameEnd = false;
    public GameObject cube;
    public Material Basic;
    public GameObject GameEndedUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            End();
        }
    }

    void End()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GameEndedUI.SetActive(true);
        Time.timeScale = 0f;
        GameEnd = true;
    }

    public void Retry()
    {
        GameEndedUI.SetActive(false);
        Time.timeScale = 1f;
        GameEnd = false;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}