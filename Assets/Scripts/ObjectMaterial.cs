using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMaterial : MonoBehaviour
{
    public int id;

    Image MaterialImage;
    Text matname;
    Text describe;
    Text qty;

    void Start()
    {
        MaterialImage = transform.Find("MaterialImage").GetComponent<Image>();
        matname = transform.Find("Name").GetComponent<Text>();
        describe = transform.Find("Describe").GetComponent<Text>();
        qty = transform.Find("QTY").GetComponent<Text>();

        MaterialImage.sprite = MaterialMng.Instance.MaterialList[id].image;
        matname.text = MaterialMng.Instance.MaterialList[id].name;
        describe.text = MaterialMng.Instance.MaterialList[id].describe;
        qty.text = "QTY : " + MaterialMng.Instance.MaterialList[id].qty.ToString();
    }

    void Update()
    {
        qty.text = "QTY : " + MaterialMng.Instance.MaterialList[id].qty.ToString();
    }

}