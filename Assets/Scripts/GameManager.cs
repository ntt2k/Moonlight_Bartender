﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour {
    
    public static int money = 0;
    public static int level_1_star = 0;
    public static int level_2_star = 0;
    public static int level_3_star = 0;
    public Dictionary<string, int> prices;

    public static float musicVolume = 0.5f;
    public static float effectVolume = 0.5f;

    // Use this for initialization
    void Awake () {
        prices = new Dictionary<string, int>();
        prices.Add("BeerGlassFull", 6);
        prices.Add("FriesCooked", 4);
        prices.Add("everything else", 50);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
