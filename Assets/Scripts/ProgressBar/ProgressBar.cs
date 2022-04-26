using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image imgFiller;
    [SerializeField] private Text textValue;

    private float currentAmount = 0;
    private int currentValue = 0;
    private int MaxValue=100;

    private void Start()
    {
        imgFiller.fillAmount = currentAmount;
    }
    public void AddXp()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentAmount += 0.1f;
            imgFiller.fillAmount = currentAmount;
            if (currentValue != MaxValue)
            {
                currentValue += 10;
                textValue.text = $"{currentValue}XP";
            }
        }
    }
    private void Update()
    {
        AddXp();
    }
}
