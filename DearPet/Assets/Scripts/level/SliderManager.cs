using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderManager : MonoBehaviour
{
    
    [SerializeField] private Slider aclik, saglik, eglence, bilgi;

   
    [SerializeField] private float aclikV, saglikV,eglenceV,bilgiV;

    [Header("AzalmaMiktarlarý")]
    [SerializeField] private float aclikA, saglikA, eglenceA, bilgiA;

    private void Start()
    {
        aclik.maxValue = 100;
        saglik.maxValue = 100;
        eglence.maxValue = 100;
        bilgi.maxValue = 100;

        aclik.value = aclikV;
        saglik.value = saglikV;
        eglence.value = eglenceV;
        bilgi.value = bilgiV;
    }

    private void Update()
    {
        DecreaseSliders();
        UpdateUI();
    }

    void DecreaseSliders()
    {
        aclikV-=aclikA*Time.deltaTime;
        saglikV-=saglikA*Time.deltaTime;
        eglenceV-=eglenceA*Time.deltaTime;
        bilgiV-=bilgiA*Time.deltaTime;

        aclikV = Mathf.Clamp(aclikV,0f,100f);
        saglikV = Mathf.Clamp(saglikV, 0f, 100f);
        eglenceV = Mathf.Clamp(eglenceV, 0f, 100f);
        bilgiV = Mathf.Clamp(bilgiV, 0f, 100f);
    }

    void UpdateUI()
    {
        aclik.value = aclikV;
        saglik.value= saglikV;
        eglence.value= eglenceV;
        bilgi.value= bilgiV;
    }

    //dýþarýdan müdahale için 

    public void aclikArttýr(float deger)
    {
        aclikV += deger;
    }
    public void saglikArttýr(float deger)
    {
        saglikV += deger;
    }
    public void eglenceArttýr(float deger)
    {
        eglenceV += deger;
    }
    public void bilgiArttýr(float deger)
    {
        bilgiV += deger;
    }
}
