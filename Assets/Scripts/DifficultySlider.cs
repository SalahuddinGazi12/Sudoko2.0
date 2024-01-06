using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySlider : MonoBehaviour
{
    public Slider difficultySlider;

    private readonly int minDifficulty = 1;
    private readonly int maxDifficulty = 9;

    public void Start()
    {
        // Set the initial difficulty level based on the slider value
        PlayerSettings.difficulty = GetMappedDifficulty(difficultySlider.value);
        // Subscribe to the slider's value change event
        difficultySlider.onValueChanged.AddListener(delegate { SliderChange(); });
    }

    public void SliderChange()
    {
        // Update the difficulty level when the slider value changes
        PlayerSettings.difficulty = GetMappedDifficulty(difficultySlider.value);
    }

    private int GetMappedDifficulty(float sliderValue)
    {
        // Map the normalized slider value to a difficulty level
        int difficultyLevel = Mathf.RoundToInt(Mathf.Lerp(minDifficulty, maxDifficulty, sliderValue));
        return Mathf.Clamp(difficultyLevel, minDifficulty, maxDifficulty);
    }


}
