using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_UP : MonoBehaviour
{
    public static bool done;
    public GameObject Sucessfully;
    public GameObject Facebook;
    public GameObject TimeLine;
    public bool test;
    public GameObject Load;
    public static bool grim;
    public GameObject lose_panel;
    void Start()
    {
        if (test) 
        {
           // PlayerPrefs.SetFloat("Facebook",0) ;
        }
       /* if (PlayerPrefs.GetFloat("Facebook") == 1)
        {
            Sucessfully.SetActive(true);
            StartCoroutine(LoadYourAsyncScene());
        }*/
      /*  else
        {

            Invoke("disableV", 3);
        }*/
    
        Invoke("disableV", 3);


    }
    public void Update()
    {
     /*   if (done) 
        {
            done = false;
            Facebook.SetActive(false);
            TimeLine.SetActive(true);
        }*/
        if (grim)
        {
            grim = false;
            Facebook.SetActive(false);
            lose_panel.SetActive(true);


        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.
        yield return new WaitForSeconds(2);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    public void disableV() 
    {

        //Facebook.SetActive(true);
        Load.SetActive(false);
        
    }
}