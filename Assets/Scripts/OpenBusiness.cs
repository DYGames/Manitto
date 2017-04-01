using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBusiness : MonoBehaviour
{
    public Image BusinessImage;
    public Text BusinessName;

    public void Open(BusinessMng.GameBusiness business)
    {
        BusinessImage.transform.parent.gameObject.SetActive(true);
        BusinessImage.sprite = business.image;
        BusinessName.text = business.name;

        MaterialListHelper requirematerial = transform.GetChild(0).Find("RequireMaterial").GetComponent<MaterialListHelper>();
        requirematerial.materiallist = business.RequireMaterial;
        MaterialListHelper returnmaterial = transform.GetChild(0).Find("ReturnMaterial").GetComponent<MaterialListHelper>();
        returnmaterial.materiallist = business.ReturnMaterial;

        requirematerial.Open();
        returnmaterial.Open();
    }

    public void Accept()
    {
        List<Vector2> requirematerial = transform.GetChild(0).Find("RequireMaterial").GetComponent<MaterialListHelper>().materiallist;
        bool fail = false;
        for (int i = 0; i < requirematerial.Count; i++)
        {
            if (MaterialMng.Instance.MaterialList[(int)requirematerial[i].y].qty < requirematerial[i].x)
                fail = true;
        }

        if (fail)
            return;
        for (int i = 0; i < requirematerial.Count; i++)
        {
            MaterialMng.Instance.MaterialList[(int)requirematerial[i].y].qty -= (int)requirematerial[i].x;
        }

        List<Vector2> returnmaterial = transform.GetChild(0).Find("ReturnMaterial").GetComponent<MaterialListHelper>().materiallist;

        for (int i = 0; i < returnmaterial.Count; i++)
        {
            Debug.Log("w");
            Debug.Log(MaterialMng.Instance.MaterialList[(int)returnmaterial[i].y].qty);
            Debug.Log((int)returnmaterial[i].x);
            MaterialMng.Instance.MaterialList[(int)returnmaterial[i].y].qty += (int)returnmaterial[i].x;
            Debug.Log(MaterialMng.Instance.MaterialList[(int)returnmaterial[i].y].qty);
        }


        Close();
    }

    public void Close()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

}
