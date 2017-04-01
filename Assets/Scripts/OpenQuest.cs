using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenQuest : MonoBehaviour
{
    public Text question;
    public Text describe;
    public Image QuestImage;

    public void Open(Quest quest)
    {
        question.transform.parent.gameObject.SetActive(true);
        question.text = quest.question;
        describe.text = quest.describe;
        QuestImage.sprite = quest.QuestImage;


        Debug.Log(quest.RequireMaterial.Count);
        MaterialListHelper requirematerial = transform.GetChild(0).Find("RequireMaterial").GetComponent<MaterialListHelper>();
        requirematerial.materiallist = quest.RequireMaterial;
        MaterialListHelper returnmaterial = transform.GetChild(0).Find("ReturnMaterial").GetComponent<MaterialListHelper>();
        returnmaterial.materiallist = quest.ReturnMaterial;

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
            MaterialMng.Instance.MaterialList[(int)returnmaterial[i].y].qty += (int)returnmaterial[i].x;
        }

        Close();
    }

    public void Close()
    {
        question.transform.parent.gameObject.SetActive(false);
    }

}
