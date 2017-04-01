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
            requirematerial.Add(new Vector2(1, 1));
            requirematerial.Add(new Vector2(2, 2));
            requirematerial.Add(new Vector2(3, 3));
            List<Vector2> returnmaterial = new List<Vector2>();
            returnmaterial.Add(new Vector2(4, 4));
            returnmaterial.Add(new Vector2(5, 5));
            returnmaterial.Add(new Vector2(6, 6));

            BusinessList.Add(i, new GameBusiness(i, null, i.ToString(), requirematerial, returnmaterial));
        }
    }

    public int GetCount()
    {
        return BusinessList.Count;
    }
}
