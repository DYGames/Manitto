using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialMng : IListMng
{
    private static MaterialMng instance;
    public static MaterialMng Instance
    {
        get
        {
            if (instance == null)
                instance = new MaterialMng();
            return instance;
        }
    }
    [Serializable]
    public class GameMaterial
    {
        public GameMaterial(int id_, Sprite image_, string name_, string describe_, int qty_)
        {
            id = id_;
            image = image_;
            name = name_;
            describe = describe_;
            qty = qty_;
        }
        public int id;
        public Sprite image;
        public string name;
        public string describe;
        public int qty;
    }

    public Dictionary<int, GameMaterial> MaterialList;
    MaterialMng()
    {
        MaterialList = new Dictionary<int, GameMaterial>();

        MaterialList.Add(0, new GameMaterial(0, null, "석유", "석유이다.", 999));
        MaterialList.Add(1, new GameMaterial(1, null, "석탄", "석탄이다.", 999));
        MaterialList.Add(2, new GameMaterial(2, null, "철", "철이다.", 999));
        MaterialList.Add(3, new GameMaterial(3, null, "흑연", "흑연이다.", 999));
        MaterialList.Add(4, new GameMaterial(4, null, "고무", "고무이다.", 999));
        MaterialList.Add(5, new GameMaterial(5, null, "전기", "전기이다.", 999));
        MaterialList.Add(6, new GameMaterial(6, null, "물", "물이다.", 999));
        MaterialList.Add(7, new GameMaterial(7, null, "가스", "가스이다.", 999));
        MaterialList.Add(8, new GameMaterial(8, null, "알루미늄", "알루미늄이다.", 999));
        MaterialList.Add(9, new GameMaterial(9, null, "금", "금이다.", 999));
        MaterialList.Add(10, new GameMaterial(10, null, "은", "은이다.", 999));
        MaterialList.Add(11, new GameMaterial(11, null, "구리", "구리이다.", 999));
        MaterialList.Add(12, new GameMaterial(12, null, "납", "납이다.", 999));
        MaterialList.Add(13, new GameMaterial(13, null, "네온", "네온이다.", 999));
        MaterialList.Add(14, new GameMaterial(14, null, "불", "불이다.", 999));
    }

    public int GetCount()
    {
        return MaterialList.Count;
    }
}
