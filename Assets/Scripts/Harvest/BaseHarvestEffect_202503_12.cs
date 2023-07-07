using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect_202503_12 : BaseHarvestEffect
{
    private float baba_timer;
    private bool baba_isPlaying;
    private GameObject baba_effectPrefab;
    private GameObject baba_effectInstance;
    // Start is called before the first frame update
    public override void Initialize()
    {
        baba_timer = 0.0f;
        baba_isPlaying = false;
        baba_effectPrefab = Resources.Load<GameObject>("Prefabs/202503_12/Particle System");
        baba_effectInstance = null;
    }
    // Update is called once per frame
    public override void Update()
    {
        if (baba_isPlaying)
        {
            baba_timer -= Time.deltaTime;
            if (baba_timer < 0.0f)
            {
                GameObject.Destroy(baba_effectInstance);
                baba_isPlaying = false;
                baba_effectInstance = null;
            }
        }
    }
    public override void PlayHarvest()
    {
        // base.PlayHarvest();
        if (baba_effectInstance == null)
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = 3f;
            baba_effectInstance = GameObject.Instantiate(baba_effectPrefab,Camera.main.ScreenToWorldPoint(mousePosition),Quaternion.identity);
            baba_timer = 0.5f;
            baba_isPlaying = true;
        }
    }
}
