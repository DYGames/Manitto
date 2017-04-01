using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMark : MonoBehaviour
{
    SpriteRenderer myrenderer;
    SpriteRenderer parentrenderer;

    void Start()
    {
        myrenderer = GetComponent<SpriteRenderer>();
        parentrenderer = transform.parent.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        myrenderer.sortingOrder = parentrenderer.sortingOrder;
    }

    public void OnMouseDown()
    {
        FindObjectOfType<OpenQuest>().Open(transform.parent.GetComponent<People>().currentQuest);
        gameObject.SetActive(false);
    }
}
