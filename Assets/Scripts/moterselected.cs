using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moterselected : MonoBehaviour
{
    public Button select;


    // Start is called before the first frame update
    void Start()
    {
        select.onClick.AddListener(nextslide);
    }

    public void nextslide()
    {

        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
