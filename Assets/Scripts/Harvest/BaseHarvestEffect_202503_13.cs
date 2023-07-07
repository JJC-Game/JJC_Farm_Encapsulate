using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_13 : BaseHarvestEffect
{
    private GameObject YamaguchiEffect;
    private float Timer;
    private bool Yamaguchi_isPlaying;
    private GameObject Yamaguchi_effectInstance;

    // Start is called before the first frame update
    public override void Initialize()
    {
        YamaguchiEffect = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_13Yamaguchi/YamaguchiEffect");
        Timer = 0.0f;
        Yamaguchi_isPlaying = false;
        Yamaguchi_effectInstance = null;
    }

    // Update is called once per frame
    public override void Update()
    {
        if (Yamaguchi_isPlaying)
        {
            Timer -= Time.deltaTime;
            if (Timer < 0.0f)
            {
                GameObject.Destroy(Yamaguchi_effectInstance);
                Yamaguchi_isPlaying = false;
                Yamaguchi_effectInstance = null;
            }
        }
    }

     public override void PlayHarvest()
    {
        if (Yamaguchi_effectInstance == null)
        {
            Yamaguchi_effectInstance = GameObject.Instantiate(YamaguchiEffect);
            Timer = 2.0f;
            Yamaguchi_isPlaying = true;
        }
    }
}
