﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FrogData", menuName = "Frog/NewFrog", order = 1)]
public class FrogData : ScriptableObject
{
    public enum FrogType { Normal, Rare, Epic, Legendary }
    public Sprite sadSprite;
    public Sprite happySprite;
    public Sprite headgearSprite;
    public Sprite outfitSprite;
    public RuntimeAnimatorController kamykAnimation;
    public int maximumSadnessLevel = 10;

    [Tooltip("im wieksze tym czesciej sie pojawia")]
    public int rarity = 100;
    public int normalLootChance = 0;
    public int rareLootChance = 0;
    public int epicLootChance = 0;
    public int legendaryLootChance = 0;
    public int minCoinsLoot = 1;
    public int maxCoinsLoot = 1;
    public FrogType type = FrogType.Normal;
    public int price = 20;
    public bool isUnlocked = false;
    public string frogName;
}
