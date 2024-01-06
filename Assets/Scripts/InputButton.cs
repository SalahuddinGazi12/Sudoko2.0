using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputButton : MonoBehaviour
{
    public static InputButton instance;
    SudokuCell lastCell;

    private void Awake()
    {
        instance = this;
    }

    
    void Start()
    {
      
    }

    public void ActivateInputButton(SudokuCell cell)
    {
        this.gameObject.SetActive(true);
        lastCell= cell;
    }

    public void ClickedButton(int num)
    {

        lastCell.UpdateValue(num);
       
    }



}
