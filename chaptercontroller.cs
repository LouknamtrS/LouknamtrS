using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chaptercontroller : MonoBehaviour
{
    [SerializeField] Button bonusBT;
    [SerializeField] Button L1_nature,L2_food,L3_history;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //go manager
    public void gotobonus()
    {
        SceneManager.LoadScene("bonusScene");
        Debug.Log("bonus scene");
    }
    public void gotoL1()
    {
        SceneManager.LoadScene("NatureScene");
        Debug.Log("NatureScene");
    }
    public void gotoL2()
    {
        SceneManager.LoadScene("FoodScene");
        Debug.Log("FoodScene");
    }
    public void gotoL3()
    {
        SceneManager.LoadScene("HistoryScene");
        Debug.Log("HistoryScence");
    }

}
