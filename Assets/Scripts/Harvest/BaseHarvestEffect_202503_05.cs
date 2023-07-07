using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_05 : BaseHarvestEffect
{
    private float timer;
    private bool playFLG;
    private GameObject effectPrefab;
    private GameObject effectInstance;

    public override void Initialize()   
    {
        timer = 0.0f;
        playFLG = false;
        effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_05/HarvestParticle");
        effectInstance = null;
    }

    public override void Update()
    {
        if (playFLG)
        {
            timer += Time.deltaTime;
            if(timer >= 0.5f)
            {
                GameObject.Destroy(effectInstance);
                playFLG = false;
                effectInstance = null;
                timer = 0.0f;
            }
        }
    }

    public override void PlayHarvest()
    {
        if (effectInstance == null)
        {
            playFLG = true;
            effectInstance = GameObject.Instantiate(effectPrefab);
        }
    }
}
