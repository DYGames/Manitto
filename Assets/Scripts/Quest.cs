using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
    public Quest(string question_, string describe_, Sprite QuestImage_, List<Vector2> RequireMaterial_, List<Vector2> ReturnMaterial_)
    {
        question = question_;
        describe = describe_;
        QuestImage = QuestImage_;
        RequireMaterial = RequireMaterial_;
        ReturnMaterial = ReturnMaterial_;
    }
    public string question;
    public string describe;
    public Sprite QuestImage;
    public List<Vector2> RequireMaterial;
    public List<Vector2> ReturnMaterial;
}
