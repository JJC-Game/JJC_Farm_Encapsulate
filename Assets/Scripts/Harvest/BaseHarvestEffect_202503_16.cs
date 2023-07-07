using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_16 : BaseHarvestEffect
{
    private float hal_timer;
    private bool hal_isPlaying;
    private GameObject hal_effectPrefab;
    private GameObject hal_effectInstance;
    override public void Initialize()
    {
        hal_timer = 0.0f;
        hal_isPlaying = false;
        hal_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_16/halEffect");
        hal_effectInstance = null;
    }

    override public void Update()
    {
        if (hal_isPlaying)
        {
            hal_timer -= Time.deltaTime;
            if (hal_timer < 0.0f)
            {
                GameObject.Destroy(hal_effectInstance);
                hal_isPlaying = false;
                hal_effectInstance = null;
            }
        }
    }

    override public void PlayHarvest()
    {
        if (hal_effectInstance == null)
        {
            hal_effectInstance = GameObject.Instantiate(hal_effectPrefab);
            hal_timer = 2.0f;
            hal_isPlaying = true;
        }
    }

}
