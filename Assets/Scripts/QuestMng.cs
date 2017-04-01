using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMng : IListMng
{
    private static QuestMng instance;
    public static QuestMng Instance
    {
        get
        {
            if (instance == null)
                instance = new QuestMng();
            return instance;
        }
    }
    public Dictionary<int, Quest> QuestList;

    QuestMng()
    {
        QuestList = new Dictionary<int, Quest>();
        List<Vector2> requiretemp = new List<Vector2>();
        List<Vector2> returntemp = new List<Vector2>();
        for (int i = 0; i < Random.Range(2, 5); i++)
        {
            returntemp.Add(new Vector2(Random.Range(1, 3), Random.Range(0, 16)));
        }

        requiretemp.Add(new Vector2(1, 14));
        QuestList.Add(0, new Quest("적의 공격에 대비한 무기가 필요하다.", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 15));
        QuestList.Add(1, new Quest("지식을 쌓기 위한 책이 필요하다.", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 0));
        requiretemp.Add(new Vector2(1, 8));
        QuestList.Add(2, new Quest("우리 가족들이 눈이 잘 안보인다고 해, 안경이 필요해", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 2));
        requiretemp.Add(new Vector2(1, 8));
        requiretemp.Add(new Vector2(1, 0));
        QuestList.Add(3, new Quest("비가 올때마다 맞고 다니기 싫어, 우산이 필요해", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 2));
        requiretemp.Add(new Vector2(1, 0));
        requiretemp.Add(new Vector2(1, 1));
        requiretemp.Add(new Vector2(1, 4));
        QuestList.Add(4, new Quest("도로는 놓였는데 자동차가 적어, 생산량을 늘려줘", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 9));
        requiretemp.Add(new Vector2(1, 12));
        requiretemp.Add(new Vector2(1, 13));
        requiretemp.Add(new Vector2(1, 11));
        QuestList.Add(5, new Quest("휴대폰이 적어서 불편해, 생산량을 늘려줘", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 13));
        requiretemp.Add(new Vector2(1, 0));
        QuestList.Add(6, new Quest("신호등이 없어서 도로가 혼잡해, 신호등을 늘려줘", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 0));
        requiretemp.Add(new Vector2(1, 2));
        requiretemp.Add(new Vector2(1, 8));
        QuestList.Add(7, new Quest("가정, 산업용 로봇이 더 필요해", "", null, requiretemp, returntemp));
        requiretemp.Clear();

        requiretemp.Add(new Vector2(1, 5));
        requiretemp.Add(new Vector2(1, 8));
        QuestList.Add(8, new Quest("우리 가족이 놀러갈 우주정거장이 필요해", "", null, requiretemp, returntemp));
        requiretemp.Clear();

    }

    public int GetCount()
    {
        return QuestList.Count;
    }
}
