using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpdateInputField : MonoBehaviour {

    public InputField mainInputField;
    private Calendar calendar;
    //https://msdn.microsoft.com/en-us/library/bb762911(v=vs.110).aspx

    void Start(){
    	
    }

    public void UpdateField()
    {
		int dayNumb = EventSystem.current.currentSelectedGameObject.GetComponent<DayButton>().CurrentNumber();
		calendar = GameObject.FindObjectOfType<Calendar>();
       	mainInputField.text = calendar.ReturnDate(dayNumb);
    }
}