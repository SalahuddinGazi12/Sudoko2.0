using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public DifficultySwipeController swipeController;

    public void OnClick()
    {
        swipeController.SwipeLeft();
    }
    
}
