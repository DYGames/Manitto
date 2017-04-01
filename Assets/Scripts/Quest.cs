using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
    public string question;
    public string describe;
    public Sprite QuestImage;
    public List<Vector2> RequireMaterial;
    public List<Vector2> ReturnMaterial;
}
