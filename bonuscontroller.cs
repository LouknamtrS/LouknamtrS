using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class bonuscontroller : MonoBehaviour
{
    [SerializeField] Button chapBT;
    [SerializeField] Button L1_hp;// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotochap()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("chap scene");
    }
    public void gotoL1()
    {
        SceneManager.LoadScene("HPScene");
        Debug.Log("HP scene");
    }
}
