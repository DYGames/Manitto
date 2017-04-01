using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialListHelper : MonoBehaviour
{
    //x=개수y=인덱스
    public List<Vector2> materiallist;
    public GameObject ElementPrefab;
    public RectTransform Content;
    public RectTransform ContentParent;

    public void Open()
    {
        int count = materiallist.Count;
        float elementheight = ElementPrefab.GetComponent<RectTransform>().sizeDelta.y;
        Content.sizeDelta = new Vector2(Content.sizeDelta.x, count * elementheight);
        for (int i = 0; i < count; i++)
        {
            GameObject material = GameObject.Instantiate(ElementPrefab);
            material.transform.SetParent(ContentParent);
            material.transform.localPosition = new Vector3(0, 40 - (elementheight * i), 0);
            material.GetComponent<ObjectMaterial>().id = i;
        }
    }
}
