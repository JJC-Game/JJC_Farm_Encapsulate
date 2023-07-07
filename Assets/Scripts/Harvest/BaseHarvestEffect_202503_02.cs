using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_02 : BaseHarvestEffect
{
    private float ikeda_timer;
    private bool ikeda_isPlaying;
    private GameObject ikeda_effectPrefab;
    private GameObject ikeda_effectInstance;
    // Start is called before the first frame update
    public override void Initialize()
    {
        ikeda_timer = 0.0f;
        ikeda_isPlaying = false;
        ikeda_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_02/IkedaEffect");
        ikeda_effectInstance = null;
    }

    // Update is called once per frame
    public override  void Update()
    {
        if (ikeda_isPlaying)
        {
            ikeda_timer -= Time.deltaTime;
            if (ikeda_timer < 0.0f)
            {
                GameObject.Destroy(ikeda_effectInstance);
                ikeda_isPlaying = false;
                ikeda_effectInstance = null;
            }
        }
    }

    public override void PlayHarvest()
    {
        if (ikeda_effectInstance == null)
        {
            ikeda_effectInstance = GameObject.Instantiate(ikeda_effectPrefab);
            ikeda_timer = 2.0f;
            ikeda_isPlaying = true;
        }
    }
}
