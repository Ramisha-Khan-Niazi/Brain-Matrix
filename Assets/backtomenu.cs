using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenu : MonoBehaviour
{
    public static bool Menu;
    public GameObject Facebook;
    public bool start;
    public void menu() 
    {
        if (start) 
        {
            Instantiate(Facebook, this.gameObject.transform.position, Quaternion.identity);
        }
        else 
        {
            SceneManager.LoadScene("menu");
        }
        //Facebook.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Menu) 
        {
            Menu = false;
            SceneManager.LoadScene("menu");
        }
    }

}
