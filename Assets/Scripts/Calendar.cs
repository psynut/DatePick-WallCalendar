using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Calendar : MonoBehaviour {

		private int selectedYear, selectedMonth, daysInMonth;
		private DateTime dtSelected;
		private Text monthYearText;

	void Awake () {
		monthYearText = GetComponent<Text>();
		dtSelected = DateTime.Today;
		selectedYear = dtSelected.Year;
		selectedMonth = dtSelected.Month;
		monthYearText.text = dtSelected.ToString("MMMM yyyy");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BackMonth(){
		dtSelected = dtSelected.AddMonths(-1);
		selectedYear = dtSelected.Year;
		selectedMonth = dtSelected.Month;
		monthYearText.text = dtSelected.ToString("MMMM yyyy");
		DayButton[] dayButtons = GameObject.FindObjectsOfType(typeof(DayButton)) as DayButton[];
		for (int i = 0; i < dayButtons.Length; i++){
			dayButtons[i].NumberDays();
		}		
	}

	public void ForwardMonth(){
		dtSelected = dtSelected.AddMonths(1);
		selectedYear = dtSelected.Year;
		selectedMonth = dtSelected.Month;
		monthYearText.text = dtSelected.ToString("MMMM yyyy");
		DayButton[] dayButtons = GameObject.FindObjectsOfType(typeof(DayButton)) as DayButton[];
		for (int i = 0; i < dayButtons.Length; i++){
			dayButtons[i].NumberDays();		
		}
	}

	public void BackYears(){
		dtSelected = dtSelected.AddYears(-1);
		selectedYear = dtSelected.Year;
		selectedMonth = dtSelected.Month;
		monthYearText.text = dtSelected.ToString("MMMM yyyy");
		DayButton[] dayButtons = GameObject.FindObjectsOfType(typeof(DayButton)) as DayButton[];
		for (int i = 0; i < dayButtons.Length; i++){
			dayButtons[i].NumberDays();
		}		
	}

	public void ForwardYear(){
		dtSelected = dtSelected.AddYears(1);
		selectedYear = dtSelected.Year;
		selectedMonth = dtSelected.Month;
		monthYearText.text = dtSelected.ToString("MMMM yyyy");
		DayButton[] dayButtons = GameObject.FindObjectsOfType(typeof(DayButton)) as DayButton[];
		for (int i = 0; i < dayButtons.Length; i++){
			dayButtons[i].NumberDays();		
		}
	}

	//Returns day of the week for the first day of the month. Sunday starts at 1 - Saturday is 7
	public int FirstOfMonthDay(){
		DateTime firstOfMonth =  new DateTime (selectedYear, selectedMonth, 1);
		return (int)firstOfMonth.DayOfWeek+1;
	}
	public int DaysInMonth(){
		return DateTime.DaysInMonth(selectedYear, selectedMonth);
	}
	public string ReturnDate(int selectedDay){
		DateTime selectedDate = new DateTime (selectedYear, selectedMonth, selectedDay);
		return selectedDate.ToString("MM/dd/yyyy");
	}
}
