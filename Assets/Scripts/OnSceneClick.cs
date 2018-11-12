﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnSceneClick : MonoBehaviour
{
    private GameObject frogPrefab;
    private Frog frogScript;
    private List<GameObject> happyFrogs;
    private GameObject currentFrog;
	private RzabaSpawner rzabkaGiver;
    private FlowerManager flowerManager;
    private HudCounterController hudCounterController;


    void Start()
    {
        this.frogScript = GameObject.Find("Frog").GetComponent<Frog>();
        this.flowerManager = new FlowerManager();
        this.happyFrogs = new List<GameObject>();
        this.currentFrog = GameObject.Find("Frog");
		this.rzabkaGiver = GameObject.Find("RzabaSpawner").GetComponent<RzabaSpawner>();
        this.hudCounterController = GameObject.Find("HudCounter").GetComponent<HudCounterController>();
        Screen.orientation = ScreenOrientation.Portrait;
    }

    void OnGUI()
    {
        if (Event.current.type == EventType.MouseDown)
        {
            this.flowerManager.SpawnFlower();
        }
    }

    void Update()
    {
        this.flowerManager.flowers.ForEach(flower =>
        {
            flower.FlyToFrog(this.frogScript.gameObject);
            if (flower.hitsFrog(this.frogScript.gameObject))
            {
                this.flowerManager.RemoveFlower(flower);
                this.frogScript.TakeFlowers(10);
                this.hudCounterController.Increment();
            }
        });

        if (!frogScript.IsSad())
        {
            ZaboPodmieniarka(rzabkaGiver.ProszemDacRzabke(this.frogScript.transform.position));
        }
    }

    IEnumerator Remover(GameObject frogo)
    {
        yield return new WaitForSeconds(2);
        happyFrogs.Remove(frogo);
        Destroy(frogo);
    }

	private void ZaboPodmieniarka(GameObject frog)
	{
            this.happyFrogs.Add(this.currentFrog);
            StartCoroutine(Remover(this.currentFrog));
            this.currentFrog = frog;
            this.frogScript = this.currentFrog.GetComponent<Frog>();
	}
}
