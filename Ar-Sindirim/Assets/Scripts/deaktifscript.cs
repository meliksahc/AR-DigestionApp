using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deaktifscript : MonoBehaviour
{
    public GameObject sespanel;
    public GameObject karacigerInfo;
    public GameObject agızInfo;
    public GameObject yemekBInfo;
    public GameObject mideInfo;
    public GameObject pankreasInfo;
    public GameObject anüsInfo;
    public GameObject safraInfo;
    public GameObject bagırsakInfo;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClickedSesButonu()
    {
        if (sespanel.activeInHierarchy == true)
            sespanel.SetActive(false);
        else
            sespanel.SetActive(true);
    }
    public void whenButtonClickedkaracigerInfo()
    {
        if (karacigerInfo.activeInHierarchy == true)
            karacigerInfo.SetActive(false);
        else
            karacigerInfo.SetActive(true);
    }
    public void whenButtonClickedagızInfo()
    {
        if (agızInfo.activeInHierarchy == true)
            agızInfo.SetActive(false);
        else
            agızInfo.SetActive(true);
    }
    public void whenButtonClickedyemekBInfo()
    {
        if (yemekBInfo.activeInHierarchy == true)
            yemekBInfo.SetActive(false);
        else
            yemekBInfo.SetActive(true);
    }
    public void whenButtonClickedmideInfo()
    {
        if (mideInfo.activeInHierarchy == true)
            mideInfo.SetActive(false);
        else
            mideInfo.SetActive(true);
    }
    public void whenButtonClickedpankreasInfo()
    {
        if (pankreasInfo.activeInHierarchy == true)
            pankreasInfo.SetActive(false);
        else
            pankreasInfo.SetActive(true);
    }
    public void whenButtonClickedanüsInfo()
    {
        if (anüsInfo.activeInHierarchy == true)
            anüsInfo.SetActive(false);
        else
            anüsInfo.SetActive(true);
    }
    public void whenButtonClickedsafraInfo()
    {
        if (safraInfo.activeInHierarchy == true)
            safraInfo.SetActive(false);
        else
            safraInfo.SetActive(true);
    }
    public void whenButtonClickedbagırsakInfo()
    {
        if (bagırsakInfo.activeInHierarchy == true)
            bagırsakInfo.SetActive(false);
        else
            bagırsakInfo.SetActive(true);
    }
}
