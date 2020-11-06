using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    //public GameObject cubes;
    //GameObject[]
    [System.Serializable]
    public class Pooliz
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pooliz> Pools;
    public Dictionary<string, Queue<GameObject>> poolItems;


    // Start is called before the first frame update
    void Start()
    {
        poolItems = new Dictionary<string, Queue<GameObject>>();

        foreach (Pooliz pool in Pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject ob = Instantiate(pool.prefab);
                ob.SetActive(false);
                objectPool.Enqueue(ob);
            }

            poolItems.Add(pool.tag, objectPool);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject SpawnPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (poolItems.ContainsKey(tag))
        {
            Debug.LogWarning("pool with tag" + tag + " Doesn't excist.");
            return null;
        }
        GameObject SpawnObject = poolItems[tag].Dequeue();

        SpawnObject.SetActive(true);
        SpawnObject.transform.position = position;
        SpawnObject.transform.rotation = rotation;

        poolItems[tag].Enqueue(SpawnObject);
        return SpawnObject;
    }
}
