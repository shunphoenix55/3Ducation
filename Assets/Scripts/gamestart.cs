using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gamestart : MonoBehaviour
{
    // Start is called before the first frame update
    public Button start;


    void Start()
    {
        start.onClick.AddListener(StartGame); 
        
    }

    public void StartGame()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }
}
