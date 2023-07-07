using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_14 : BaseHarvestEffect
{
    private float yoshioka_timer;
    private bool yoshioka_isPlaying;
    private GameObject yoshioka_effectPrefab;
    private GameObject yoshioka_effectInstance;
    override public void Initialize()
    {


        {
            yoshioka_timer = 0.0f;
            yoshioka_isPlaying = false;
            yoshioka_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_14/YoshiokaEffect");
            yoshioka_effectInstance = null;
        }
    }

    override public void Update()
    {
        if (yoshioka_isPlaying)
        {
            yoshioka_timer -= Time.deltaTime;
            if (yoshioka_timer < 0.0f)
            {
                GameObject.Destroy(yoshioka_effectInstance);
                yoshioka_isPlaying = false;
                yoshioka_effectInstance = null;
            }
        }
    }

    override public void PlayHarvest()
    {
        if (yoshioka_effectInstance == null)
        {
            yoshioka_effectInstance = GameObject.Instantiate(yoshioka_effectPrefab);
            yoshioka_timer = 2.0f;
            yoshioka_isPlaying = true;
        }
    }
}


