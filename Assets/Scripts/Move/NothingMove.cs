using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class NothingMove : Move {
	
	public new void UseMove(Hero user)
	{
		Debug.Log(user.GetName() + " does not move!");
	}
    
}