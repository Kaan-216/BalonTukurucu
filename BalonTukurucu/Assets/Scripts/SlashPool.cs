using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashPool : MonoBehaviour
{
    public static SlashPool instance;
    private int amountToPool = 32;

    private List<GameObject> slashespool = new List<GameObject>();

    [SerializeField] private GameObject slashPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject slash = Instantiate(slashPrefab);
            slash.SetActive(false);
            slashespool.Add(slash);
        }
    }

    public GameObject GetPooledSlash()
    {
        for (int i = 0; i < slashespool.Count; i++)
        {
            if (!slashespool[i].activeInHierarchy)
            {
                return slashespool[i];
            }
        }
        return null;
    }
}
