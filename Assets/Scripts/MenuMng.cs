using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMng : MonoBehaviour
{
    Text PeriodText;

    void Start()
    {
        PeriodText = transform.Find("Period").GetComponent<Text>();
    }

    void Update()
    {
        PeriodText.text = PeriodMng.Instance.currentPeriod.ToString();
    }

    public void onClickMenu()
    {
        GameObject menuparent = transform.Find("Menu").Find("MenuParent").gameObject;
        menuparent.SetActive(!menuparent.activeSelf);
    }

    public void onClickMaterialMenu()
    {
        GameObject materiallist = transform.parent.Find("MaterialList").gameObject;
        materiallist.SetActive(!materiallist.activeSelf);
    }

    public void onClickBusinessMenu()
    {
        GameObject businesslist = transform.parent.Find("BusinessList").gameObject;
        businesslist.SetActive(!businesslist.activeSelf);
    }

    public void onClickExitMenu()
    {
        Application.Quit();
    }
}
