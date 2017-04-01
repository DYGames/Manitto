using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInLayerToPositionY : MonoBehaviour
{
    SpriteRenderer spriterenderer;

    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (spriterenderer)
            spriterenderer.sortingOrder = -((int)(transform.localPosition.y * 100));
    }
}