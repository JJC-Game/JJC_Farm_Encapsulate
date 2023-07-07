using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_11 : BaseHarvestEffect
{
    private float hane_timer;
    private bool hane_isPlaying;
    private GameObject hane_effectPrefab;
    private GameObject hane_effectInstance;

    override public void Initialize()
    {
        hane_timer = 0.0f;
        hane_isPlaying = false;
        hane_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_11/haniudaEffect");
        hane_effectInstance = null;
    }

    override public void Update()
    {
        if (hane_isPlaying)
        {
            hane_timer -= Time.deltaTime;
            if (hane_timer < 0.0f)
            {
                GameObject.Destroy(hane_effectInstance);
                hane_isPlaying = false;
                hane_effectInstance = null;
            }
        }
    }

    override public void PlayHarvest()
    {
        if (hane_effectInstance == null)
        {
            hane_effectInstance = GameObject.Instantiate(hane_effectPrefab);
            hane_timer = 2.0f;
            hane_isPlaying = true;
        }
    }
}
