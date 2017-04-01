using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ListHelper : MonoBehaviour
{
    public GameObject ElementPrefab;
    public RectTransform Content;
    public RectTransform ContentsParent;
    public string MngofListName;

    void Start()
    {
        Open();
    }

    void Open()
    {
        MethodInfo getcount = Type.GetType(MngofListName).GetMethod("GetCount");
        int count = 0;
        if (MngofListName.Equals("MaterialMng"))
        {
            count = (int)getcount.Invoke(MaterialMng.Instance, null);
        }
        else if (MngofListName.Equals("BusinessMng"))
        {
            count = (int)getcount.Invoke(BusinessMng.Instance, null);
        }

        float elementheight = ElementPrefab.GetComponent<RectTransform>().sizeDelta.y;
        for (int i = 0; i < count; i++)
        {
            GameObject material = GameObject.Instantiate(ElementPrefab);
            material.transform.SetParent(ContentsParent);
            material.transform.localPosition = new Vector3(0, -(elementheight * i));
            if (MngofListName.Equals("MaterialMng"))
            {
                material.GetComponent<ObjectMaterial>().id = i;
            }
            else if (MngofListName.Equals("BusinessMng"))
            {
                material.GetComponent<ObjectBusiness>().id = i;
            }
        }

        Content.sizeDelta = new Vector2(Content.sizeDelta.x, count * elementheight);
    }

    void Close()
    {

    }
}
