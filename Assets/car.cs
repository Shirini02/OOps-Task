using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is empty card class
public class car 
{

    public string carName;
    public int makeYear;
    public float maxSpeed;

    //Constructor
    public car()
    {
        Debug.Log(" Car Default constructor");
    }
    public car(float maximumSpeed)
    {
        maxSpeed = maximumSpeed;
        Debug.Log("maximum speed:" + maxSpeed);
        Debug.Log("second constructor called");
    }
    public car(int year, string name)
    {
        this.makeYear = year;
        this.carName = name;

    }


    //behaviour or methods
    public void Drive()
    {
        Debug.Log("This is to Drive a car:" + carName);
    }
    public void ApplyBrake()
    {
        Debug.Log("This is to apply car brake");
    }
    public void PrintCarDetails()
    {
        Debug.Log("car name is" + carName);
        Debug.Log("car make year is" + makeYear);
        Debug.Log("the car maxspeed is" + maxSpeed);
    }

}




