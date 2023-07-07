using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestManager : MonoBehaviour
{
    public int harbestId;

    List<BaseHarvestEffect> effectList;

    BaseHarvestEffect effect1_3_4_7_10;
    BaseHarvestEffect_202503_02 effect2;
    BaseHarvestEffect_202503_05 effect5;
    BaseHarvestEffect_202503_06 effect6;
    BaseHarvestEffect_202503_08 effect8;
    BaseHarvestEffect_202503_09 effect9;
    BaseHarvestEffect_202503_11 effect11;
    BaseHarvestEffect_202503_12 effect12;
    Effect202503_13 effect13;
    Effectmanager202503_14 effect14;
    BaseHarvestEffect_202503_15 effect15;
    BaseHarvestEffect_202503_16 effect16;
    




    // Start is called before the first frame update
    void Start()
    {
        effectList = new List<BaseHarvestEffect>();
        effect1_3_4_7_10 = new BaseHarvestEffect();
        effectList.Add(effect1_3_4_7_10);
        effect2 = new BaseHarvestEffect_202503_02();
        effectList.Add(effect2);
        effectList.Add(effect1_3_4_7_10);
        effectList.Add(effect1_3_4_7_10);
        effect5 = new BaseHarvestEffect_202503_05();
        effectList.Add(effect5);
        effect6 = new BaseHarvestEffect_202503_06();
        effectList.Add(effect6);
        effectList.Add(effect1_3_4_7_10);
        effect8 = new BaseHarvestEffect_202503_08();
        effectList.Add(effect8);
        effect9 = new BaseHarvestEffect_202503_09();
        effectList.Add(effect9);
        effectList.Add(effect1_3_4_7_10);
        effect11 = new BaseHarvestEffect_202503_11();
        effectList.Add(effect11);
        effect12 = new BaseHarvestEffect_202503_12();
        effectList.Add(effect12);
        effect13 = new Effect202503_13();
        effectList.Add(effect13);
        effect14 = new Effectmanager202503_14();
        effectList.Add(effect14);
        effect15 = new BaseHarvestEffect_202503_15();
        effectList.Add(effect15);
        effect16 = new BaseHarvestEffect_202503_16();
        effectList.Add(effect16);


        for (int i = 0; i < effectList.Count; i++)
        {
            effectList[i].Initialize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < effectList.Count; i++)
        {
            effectList[i].Update();
        }

    }

    public void PlayHarvest()
    {
        effectList[harbestId].PlayHarvest();
    }
}
