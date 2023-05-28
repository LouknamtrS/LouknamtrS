using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class problem_manager : MonoBehaviour
{

    [SerializeField] private Button previousBotton;
    [SerializeField] private Button nextBotton;
    [SerializeField] private Button homeBotton;
    [SerializeField] private Button[] q;
    
    [SerializeField] private int current_question;
    [SerializeField] private int current_number;
    [SerializeField] private GameObject type_questions1,type_questions2,type_questions3;
    [SerializeField] private bool isCorrect = false;
    [SerializeField] private GameObject[] correct;
    //[SerializeField] private GameObject[] tips;
    //[SerializeField] private Button tipsBotton;
    //[SerializeField] private Text tipsMessage;

 
    private void Awake(){
        questions(0);
    }
     public void Start(){
        type_questions1.SetActive(true);
        
     }
     public void update(){
       
    
        
     }

    
    private void questions(int _questionsindex){

        previousBotton.interactable = (_questionsindex != 0);
        nextBotton.interactable = (_questionsindex != transform.childCount-1);
        for(int i = 0; i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(i == _questionsindex);
            isCorrect =false;
        }
        if(isCorrect==false){
            for(int i=0; i<10; i++){
            correct[i].SetActive(false);
            }
        }
        
    }
    private void numbers(int _numbersindex){

        previousBotton.interactable = (_numbersindex != 0);
        nextBotton.interactable = (_numbersindex != transform.childCount-1);
        for(int i = 0; i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(i == _numbersindex);
            
        }
        
    }
    private void number10(int _numbersindex){
        for(int i = 0; i < transform.childCount; i++){
            if(_numbersindex >= 8){
                transform.GetChild(i).gameObject.SetActive(i == _numbersindex);
            }
        }
    }
    public void ChangeQuestion(int _change){
        current_question += _change;
        questions(current_question);
         if(current_question >= 0 && current_question <= 4){
                type_questions1.SetActive(true);
                type_questions2.SetActive(false);
                type_questions3.SetActive(false);
            }
            else if(current_question >= 4 && current_question <= 7){
                type_questions1.SetActive(false);
                type_questions2.SetActive(true);
                type_questions3.SetActive(false);
            }
            else if(current_question >= 7){
                type_questions2.SetActive(false);
                type_questions3.SetActive(true);
            }
        

    }

    public void ansOnclick(){
        for(int i=0;i<10;i++){
            Button ans1 = q[i].GetComponent<Button>();
            ans1.onClick.AddListener(correctans);
        }
        
        isCorrect = true;
    }
    private void correctans(){
        if(isCorrect==true){
            for(int i=0; i<10; i++){
            correct[i].SetActive(true);
        }
            Debug.Log("Clicked");
        }
        
    }
    /*public void tipsOnclick(){
        Button tips = tipsBotton.GetComponent<Button>();
        tips.onClick.AddListener(showtips);
    }
    private void showtips(){
        for(int i=0;i<10;i++){
            tips[i].SetActive(true);
            tipsMessage.text = string.Format("alskfaoekfa;lsfkapowkflasfkal;sdfkwefpok");
        }
    }*/

    public void Changenumbers(int _changenumber){
        current_number += _changenumber;
        numbers(current_number);
        number10(current_number);
    }

    public void ChangeSceneHome(){
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Sample scene");
    }
    
}
