using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    public DifficultySwipeController swipeController;

    public void OnClick()
    {
        swipeController.SwipeRight();
    }
}
