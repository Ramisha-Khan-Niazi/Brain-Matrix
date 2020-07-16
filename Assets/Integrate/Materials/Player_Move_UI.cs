using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_UI : MonoBehaviour
{

    public static bool up;
    public static bool down;
    public static bool right;
    public static bool left;
     public void pressup() 
    {
        up = true;
    }
    public void pressupp()
    {
        up = false;
    }

    public void pressd()
    {
        down = false;
    }
    public void pressdd()
    {
        
        down = true;
    }

    public void pressl()
    {
        left = false;
    }
    public void pressll()
    {
        
        left = true;
    }

    public void pressr()
    {
        right = false;
    }
    public void pressrr()
    {
        
        right = true;
    }
}
