﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResourcesScript : MonoBehaviour
{

    public static event Action<int> OnCurrentCoinsNumberChange;
    public static event Action<int, GemScript.GemType> OnCurrentGemsNumberChange;
    private int currentCoinsNumber;
    private int currentNormalGemsNumber;
    private int currentRareGemsNumber;
    private int currentEpicGemsNumber;
    private int currentLegendaryGemsNumber;

    public int CurrentCoinsNumber { get; set; }

    void Start()
    {

    }

    void Update()
    {

    }

    public void IncrementCurrentCoinsNumber()
    {
        CurrentCoinsNumber++;
        if (OnCurrentCoinsNumberChange != null)
        {
            OnCurrentCoinsNumberChange(CurrentCoinsNumber);
        }
    }
    public void DecrementCurrentCoinNumber(int dec)
    {
        CurrentCoinsNumber-=  dec;
        if (OnCurrentCoinsNumberChange != null)
        {
            OnCurrentCoinsNumberChange(CurrentCoinsNumber);
        }
    }

    public void IncrementCurrentGemsNumber(GemScript.GemType type)
    {
        switch (type)
        {
            case GemScript.GemType.Normal:
                currentNormalGemsNumber++;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentNormalGemsNumber, type);
                }
                break;
            case GemScript.GemType.Rare:
                currentRareGemsNumber++;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentRareGemsNumber, type);
                }
                break;
            case GemScript.GemType.Epic:
                currentEpicGemsNumber++;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentEpicGemsNumber, type);
                }
                break;
            case GemScript.GemType.Legendary:
                currentLegendaryGemsNumber++;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentLegendaryGemsNumber, type);
                }
                break;
        }
    }

    public void SubtractFromCurrentGemsNumber(int amount, GemScript.GemType type)
    {
        switch (type)
        {
            case GemScript.GemType.Normal:
                currentNormalGemsNumber -= amount;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentNormalGemsNumber, type);
                }
                break;
            case GemScript.GemType.Rare:
                currentRareGemsNumber -= amount;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentRareGemsNumber, type);
                }
                break;
            case GemScript.GemType.Epic:
                currentEpicGemsNumber -= amount;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentEpicGemsNumber, type);
                }
                break;
            case GemScript.GemType.Legendary:
                currentLegendaryGemsNumber -= amount;
                if (OnCurrentGemsNumberChange != null)
                {
                    OnCurrentGemsNumberChange(currentLegendaryGemsNumber, type);
                }
                break;
        }
    }

    public int getCurrentGemsNumber(GemScript.GemType gemType)
    {
        switch (gemType)
        {
            case GemScript.GemType.Normal:
                return currentNormalGemsNumber;
            case GemScript.GemType.Rare:
                return currentRareGemsNumber;
            case GemScript.GemType.Epic:
                return currentEpicGemsNumber;
            case GemScript.GemType.Legendary:
                return currentLegendaryGemsNumber;
            default:
                return 0;
        }
    }
}
