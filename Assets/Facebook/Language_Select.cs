using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_Select : MonoBehaviour
{
    public GameObject Urdu;
    public GameObject English;
    bool select;
   
    public void Keypress() 
    {
        
        if (!select) 
        {
            Urdu.SetActive(true);
            English.SetActive(false);
            select = true;
        }
        else 
        {
            English.SetActive(true);
            Urdu.SetActive(false);
            select = false;
        }
    }
}
