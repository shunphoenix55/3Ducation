using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class motormenu : MonoBehaviour
{
    public Button left;
    public Button right;
    public Button selected;

    public GameObject m1;
    public GameObject m2;
    public GameObject nextslide;


    // Start is called before the first frame update
    void Start()
    {
        left.onClick.AddListener(move);
        right.onClick.AddListener(move);
        selected.onClick.AddListener(next);

    }

    public void move()
    {
        if(m1.activeSelf == true)
        {
            m1.SetActive(false);
            m2.SetActive(true);
        }
        else
        {
            m1.SetActive(true);
            m2.SetActive(false);
        }

    }

    public void next() 
    {
        nextslide.SetActive(true);
        gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
