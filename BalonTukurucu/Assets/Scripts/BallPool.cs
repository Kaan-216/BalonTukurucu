using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPool : MonoBehaviour
{
    public static BallPool instance;

    private List<GameObject> pooledaka = new List<GameObject>();
    private List<GameObject> pooledki_iro = new List<GameObject>();
    private List<GameObject> pooledao = new List<GameObject>();
    private List<GameObject> pooledmidori = new List<GameObject>();
    private List<GameObject> pooledmurasaki = new List<GameObject>();
    private int amountToPool = 32;

    [SerializeField] private GameObject akaBallPrefab;
    [SerializeField] private GameObject ki_iroBallPrefab;
    [SerializeField] private GameObject aoBallPrefab;
    [SerializeField] private GameObject midoriBallPrefab;
    [SerializeField] private GameObject murasakiBallPrefab;

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
            GameObject akaB = Instantiate(akaBallPrefab);
            akaB.SetActive(false);
            pooledaka.Add(akaB);
            GameObject  ki_iroB = Instantiate(ki_iroBallPrefab);
            ki_iroB.SetActive(false);
            pooledki_iro.Add(ki_iroB);
            GameObject  aoB = Instantiate(aoBallPrefab);
            aoB.SetActive(false);
            pooledao.Add(aoB);
            GameObject  midoriB = Instantiate(midoriBallPrefab);
            midoriB.SetActive(false);
            pooledmidori.Add(midoriB);
            GameObject  murasakiB = Instantiate(murasakiBallPrefab);
            murasakiB.SetActive(false);
            pooledmurasaki.Add(murasakiB);
        }
    }

    public GameObject GetPooledAka()
    {
        for (int i = 0; i < pooledaka.Count; i++)
        {
            if (!pooledaka[i].activeInHierarchy)
            {
                return pooledaka[i];
            }
        }
        return null;
    }

    public GameObject GetPooledKi_iro()
    {
        for (int i = 0; i < pooledki_iro.Count; i++)
        {
            if (!pooledki_iro[i].activeInHierarchy)
            {
                return pooledki_iro[i];
            }
        }
        return null;
    }

    public GameObject GetPooledAo()
    {
        for (int i = 0; i < pooledao.Count; i++)
        {
            if (!pooledao[i].activeInHierarchy)
            {
                return pooledao[i];
            }
        }
        return null;
    }

    public GameObject GetPooledMidori()
    {
        for (int i = 0; i < pooledmidori.Count; i++)
        {
            if (!pooledmidori[i].activeInHierarchy)
            {
                return pooledmidori[i];
            }
        }
        return null;
    }

    public GameObject GetPooledMurasaki()
    {
        for (int i = 0; i < pooledmurasaki.Count; i++)
        {
            if (!pooledmurasaki[i].activeInHierarchy)
            {
                return pooledmurasaki[i];
            }
        }
        return null;
    }

}
