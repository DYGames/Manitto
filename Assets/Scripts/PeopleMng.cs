using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMng : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(PeriodRoutin());
    }

    public void UpMaterial()
    {
        MaterialMng.Instance.MaterialList[0].qty += 60;
    }


    IEnumerator PeriodRoutin()
    {
        yield return new WaitForSeconds(1);
        int matn = 0;
        for (int i = 0; i < MaterialMng.Instance.MaterialList.Count; i++)
        {
            matn += MaterialMng.Instance.MaterialList[i].qty;
        }

        if (matn <= 0)
        {
            GameObject.Find("TheEnd").SetActive(true);
        }

        if (matn >= 400)
        {
            GameObject.Find("TheEnd").SetActive(true);
        }

        if (matn > 80 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.PRIMITIVE)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.MEDIAVAL);
        }
        else if (matn > 150 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.MEDIAVAL)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.MODERN);
        }
        else if (matn > 250 && PeriodMng.Instance.currentPeriod == PeriodMng.Period.MODERN)
        {
            PeriodMng.Instance.UpdatePeriod(PeriodMng.Period.FUTURE);
        }

        StartCoroutine(PeriodRoutin());
    }

}
