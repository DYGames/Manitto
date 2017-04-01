using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessMng : IListMng
{
    private static BusinessMng instance;
    public static BusinessMng Instance
    {
        get
        {
            if (instance == null)
                instance = new BusinessMng();
            return instance;
        }
    }
    public class GameBusiness
    {
        public GameBusiness(int id_, Sprite image_, string name_, List<Vector2> RequireMaterial_, List<Vector2> ReturnMaterial_)
        {
            id = id_;
            image = image_;
            name = name_;
            RequireMaterial = RequireMaterial_;
            ReturnMaterial = ReturnMaterial_;
        }
        public int id;
        public Sprite image;
        public string name;

        //material, QTY
        public List<Vector2> RequireMaterial;
        public List<Vector2> ReturnMaterial;
    }

    public Dictionary<int, GameBusiness> BusinessList;
    BusinessMng()
    {
        BusinessList = new Dictionary<int, GameBusiness>();
        for (int i = 0; i < 8; i++)
        {
            List<Vector2> requirematerial = new List<Vector2>();
            for (int j = 0; j < Random.Range(1, 4); j++)
            {
                requirematerial.Add(new Vector2(Random.Range(1, 3), Random.Range(0, 16)));
            }
            List<Vector2> returnmaterial = new List<Vector2>();

            for (int j = 0; j < Random.Range(1, 4); j++)
            {
                returnmaterial.Add(new Vector2(Random.Range(1, 3), Random.Range(0, 16)));
            }
            BusinessList.Add(i, new GameBusiness(i, null, i.ToString() + "번째 사업", requirematerial, returnmaterial));
        }
    }

    public int GetCount()
    {
        return BusinessList.Count;
    }
}
