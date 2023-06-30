using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_15 : BaseHarvestEffect
{
    private float yoshizawa_timer;
    private bool yoshizawa_isPlaying;
    private GameObject yoshizawa_effectPrefab;
    private GameObject yoshizawa_effectInstance;
    override public void Initialize()
    {
        yoshizawa_timer = 0.0f;
        yoshizawa_isPlaying = false;
        yoshizawa_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_15_Yoshizawa/zawaEffect");
        yoshizawa_effectInstance = null;
    }

    // Update is called once per frame
    override public void Update()
    {
        if (yoshizawa_isPlaying)
        {
            yoshizawa_timer -= Time.deltaTime;
            if (yoshizawa_timer < 0.0f)
            {
                GameObject.Destroy(yoshizawa_effectInstance);
                yoshizawa_isPlaying = false;
                yoshizawa_effectInstance = null;
            }
        }
    }

    override public void PlayHarvest()
    {
        if (yoshizawa_effectInstance == null)
        {
            yoshizawa_effectInstance = GameObject.Instantiate(yoshizawa_effectPrefab);
            yoshizawa_timer = 2.0f;
            yoshizawa_isPlaying = true;
        }
    }
}
