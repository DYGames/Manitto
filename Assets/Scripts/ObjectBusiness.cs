using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectBusiness : MonoBehaviour
{
    public int id;

    Image BusinessImage;
    Text BusinessName;
    Button Accept;

    void Start()
    {
        BusinessImage = transform.Find("BusinessImage").GetComponent<Image>();
        BusinessName = transform.Find("Name").GetComponent<Text>();
        Accept = transform.Find("Accept").GetComponent<Button>();

        BusinessImage.sprite = BusinessMng.Instance.BusinessList[id].image;
        BusinessName.text = BusinessMng.Instance.BusinessList[id].name;
        Accept.onClick.AddListener(delegate
       {
           FindObjectOfType<OpenBusiness>().Open(BusinessMng.Instance.BusinessList[id]);
       });
    }


}
