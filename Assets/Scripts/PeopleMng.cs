using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMng : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(PeriodRoutin());
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            MaterialMng.Instance.MaterialList[0].qty += 30;
        }
    }

    IEnumerator PeriodRoutin()
    {
        yield return new WaitForSeconds(1);
        int matn = 0;
        for (int i = 0; i < MaterialMng.Instance.MaterialList.Count; i++)
        {
            matn += MaterialMng.Instance.MaterialList[i].qty;
        }

        if(matn > 30 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.PRIMITIVE)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.MEDIAVAL);
        }
        else if(matn > 60 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.MEDIAVAL)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.MODERN);
        }
        else if(matn > 90 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.MODERN)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.FUTURE);
        }

        StartCoroutine(PeriodRoutin());
    }

}
