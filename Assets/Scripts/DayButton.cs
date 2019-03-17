using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayButton : MonoBehaviour {

	private Calendar calendar; 							//Calendar Script (attached to UI text for selected month
	private Text btext;									//text of this button
	[Tooltip("The Original Number of This Button")]	
	public int orgNumber;								//original number of each button

	void Start () {
		btext = GetComponentInChildren<Text>();
		NumberDays();
	}

	//Change the text in the button to the day of selected month
	//Blank out buttons that are not numbered
	public void NumberDays(){
		Image image = GetComponent<Image>();
		Button button = GetComponent<Button>();
    	if (CurrentNumber() <= 0 || CurrentNumber() > calendar.DaysInMonth()){
    		image.enabled = false;
    		button.enabled = false;
    		btext.text = "";
    	}else{
    		btext.text = CurrentNumber().ToString();
			button.enabled = true;
			image.enabled = true;
    	}
    }

    public int CurrentNumber(){
		calendar = GameObject.FindObjectOfType<Calendar>();
	  	return orgNumber - calendar.FirstOfMonthDay()+1;
    }
}