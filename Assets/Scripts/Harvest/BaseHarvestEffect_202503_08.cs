using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_08 : BaseHarvestEffect
{
    bool isPlaying;
    GameObject effectPrefab;

    public override void Initialize()
    {
        effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_08/NoguchiEffect");
    }

    public override void Update()
    {
        if (isPlaying && !GameObject.Find("NoguchiEffect(Clone)"))
        {
            isPlaying = false;
        }
    }

    public override void PlayHarvest()
    {
        if (!isPlaying)
        {
            GameObject.Instantiate(effectPrefab);
            isPlaying = true;
        }
    }
}