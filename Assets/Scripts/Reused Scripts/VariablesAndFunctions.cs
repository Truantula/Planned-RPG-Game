using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {


	int myInt = 0;
		
		void Start(){
			myInt = Randomize(myInt);
			Debug.Log (myInt);
		}
		
		int Randomize(int number){
			int rand;
			
			rand = Random.Range(0,11);
			if (rand > 5)
				{
					Debug.Log("It's a hit");
				}
				else 
				{
					Debug.Log("It's a miss");
				}
			return rand;
			{
				
			}
		}
}
