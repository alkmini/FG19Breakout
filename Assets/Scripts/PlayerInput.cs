using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Creating a variable
    // access modifier - data type - variable name

    // access modifier: public, private, protected
    // if no access modifier it is private
    /*public int myValue = 10; // declaring and initializing the variable. this is a member variable because it is a member of a class
    public bool isDead = false;

    private float speed = 10.5f;
    private double precisionSpeed = 10.5;
    private string myName = "Alkmini";
    private char myChar = 'c';
    */

    /* Data types
       int = whole numbers
       bool = true or false
       float = decimals. ~7 decimals
       doublw = decimals ~15 decimals
       string = text or string of characters
       char = one character
    
     */
    private Camera playerCamera; //Default value null

    // Funtions/Methods
    // access modifier, return datatype, method name, parameters
    private void Awake()
    {
        playerCamera = Camera.main; // Camera.main uses find object of the tag internally, super rude.
    }
   
}
