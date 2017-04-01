using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodMng
{
    private static PeriodMng instance;
    public static PeriodMng Instance
    {
        get
        {
            if (instance == null)
                instance = new PeriodMng();
            return instance;
        }
    }

    public enum Period
    {
        PRIMITIVE,
        MEDIAVAL,
        MODERN,
        FUTURE,
    }

    public Period currentPeriod;

    PeriodMng()
    {
        UpdatePeriod(Period.PRIMITIVE);
    }

    public void UpdatePeriod(Period newPeriod)
    {
        currentPeriod = newPeriod;

        Building[] buildings = UnityEngine.MonoBehaviour.FindObjectsOfType<Building>();
        for (int i = 0; i < buildings.Length; i++)
        {
            int id = Random.Range(1, 11);
            buildings[i].transform.GetComponent<SpriteRenderer>().sprite =
                Resources.Load<Sprite>("Building/" + currentPeriod.ToString() + "/" + id.ToString());

            buildings[i].id = id;
        }

        UnityEngine.GameObject.Find("Ground").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Ground/" + currentPeriod.ToString());
    }
}
