using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookManager : MonoBehaviour
{
    public static bookManager Instance;

    
    [SerializeField] private float infoValue;
    [SerializeField] private float infoDecreaseValue;
    public bool isReading = false;

    // kitap okuma sýrasýnda slider artmasý 

    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    
}
