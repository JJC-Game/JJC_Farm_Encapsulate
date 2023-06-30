using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect202503_13 : BaseHarvestEffect
{
    private GameObject yamaguchi_effectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        yamaguchi_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/202503_13Yamaguchi/FarmEffect");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
