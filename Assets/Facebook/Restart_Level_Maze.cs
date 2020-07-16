using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Level_Maze : MonoBehaviour
{
    public string Restart;
    public string NextM;
    public void NextLevel() 
    {
        SceneManager.LoadScene(NextM);
    }

    public void RestartGame() 
    {

        SceneManager.LoadScene(Restart);
    }
}
