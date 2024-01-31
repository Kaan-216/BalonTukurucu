using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class BallThrower : MonoBehaviour
{
    public Transform bt;
    public Transform FirePoint;
    public float BulletForce = 100;
    public float FireRate = 1;
    private float time;
    private float nextTimeFire;
    private int topSayisi;
    private int atisSayisi;
    private int hangitop;
    float rastgeleRotasyon;
    
    private GameObject HangiTopTest()
    {
        hangitop = Random.Range(1,6);
        float orijinalY = FirePoint.position.y;

        switch (hangitop)
        {
            case 1:
                FirePoint.position = new Vector3(FirePoint.position.x, FirePoint.position.y - 1f, FirePoint.position.z);
                Debug.Log("1 Kırmızı Top");
                GameObject akaball = BallPool.instance.GetPooledAka();
                    if (akaball != null)
                    {
                        akaball.transform.position = FirePoint.position;
                        akaball.SetActive(true);
                    }
                akaball.GetComponent<Rigidbody>().AddForce(FirePoint.forward*BulletForce);
                FirePoint.position = new Vector3(FirePoint.position.x, orijinalY, FirePoint.position.z);
                return akaball;
            case 2:
                Debug.Log("1 Sarı Top");
                GameObject ki_iroball = BallPool.instance.GetPooledKi_iro();
                    if (ki_iroball != null)
                    {
                        ki_iroball.transform.position = FirePoint.position;
                        ki_iroball.SetActive(true);
                    }
                ki_iroball.GetComponent<Rigidbody>().AddForce(FirePoint.forward*BulletForce);
                return ki_iroball;
            case 3:
                Debug.Log("1 Mavi Top");
                GameObject aoball = BallPool.instance.GetPooledAo();
                    if (aoball != null)
                    {
                        aoball.transform.position = FirePoint.position;
                        aoball.SetActive(true);
                    }
                aoball.GetComponent<Rigidbody>().AddForce(FirePoint.forward*BulletForce);
                return aoball;
            case 4:
                Debug.Log("1 Yeşil Top");
                GameObject midoriball = BallPool.instance.GetPooledMidori();
                    if (midoriball != null)
                    {
                        midoriball.transform.position = FirePoint.position;
                        midoriball.SetActive(true);
                    }
                midoriball.GetComponent<Rigidbody>().AddForce(FirePoint.forward*BulletForce);
                return midoriball;
            case 5:
                Debug.Log("1 Mor Top");
                FirePoint.position = new Vector3(FirePoint.position.x, FirePoint.position.y + 1f, FirePoint.position.z);
                GameObject murasakiball = BallPool.instance.GetPooledMurasaki();
                    if (murasakiball != null)
                    {
                        murasakiball.transform.position = FirePoint.position;
                        murasakiball.SetActive(true);
                    }
                murasakiball.GetComponent<Rigidbody>().AddForce(FirePoint.forward*BulletForce);
                FirePoint.position = new Vector3(FirePoint.position.x, orijinalY, FirePoint.position.z);
                return murasakiball;
            default:
                Debug.Log("Geçersiz Top");
                return null;
        }
    }

    private void AciDegistir()
    {
        float rastgeleRotationY = Random.Range(120f, 240f);
        bt.rotation = Quaternion.Euler(0f, rastgeleRotationY, 0f);
    }

    public void Awake(){
        
    }

    public void Start(){
        topSayisi = Random.Range(3,6);
        print(topSayisi);
    }

    void Update()
    {   
        time += Time.deltaTime;
        nextTimeFire = 1/FireRate;

        if (time>=nextTimeFire)
        {
            if (atisSayisi != topSayisi)
            {
                print(atisSayisi);
                HangiTopTest();
                AciDegistir();
                atisSayisi++;
                time = 0;
            }
        }

        
    }
}
