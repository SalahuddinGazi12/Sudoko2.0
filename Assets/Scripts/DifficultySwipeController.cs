using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DifficultySwipeController : MonoBehaviour
{
    public TextMeshProUGUI difficultyText; 
    private int currentDifficultyIndex = 2; 
    private string[] difficultyLevels = { "Beginner", "Easy", "Medium", "Hard", "Extreme" }; 

    private void Start()
    {
        UpdateDifficultyText();
    }

    private void UpdateDifficultyText()
    {
        difficultyText.text = difficultyLevels[currentDifficultyIndex];
    }

    public void SwipeLeft()
    {
        currentDifficultyIndex = Mathf.Max(currentDifficultyIndex - 1, 0);
        UpdateDifficultyText();
        SetDifficultyValue();
    }

    public void SwipeRight()
    {
        currentDifficultyIndex = Mathf.Min(currentDifficultyIndex + 1, difficultyLevels.Length - 1);
        UpdateDifficultyText();
        SetDifficultyValue();
    }

    private void SetDifficultyValue()
    {
        switch (currentDifficultyIndex)
        {
            case 0:
                PlayerSettings.difficulty = 10;
                break;
            case 1:
                PlayerSettings.difficulty = 20;
                break;
            case 2:
                PlayerSettings.difficulty = 30;
                break;
            case 3:
                PlayerSettings.difficulty = 45;
                break;
            case 4:
                PlayerSettings.difficulty = 60;
                break;
            default:
                break;
        }
    }
}
