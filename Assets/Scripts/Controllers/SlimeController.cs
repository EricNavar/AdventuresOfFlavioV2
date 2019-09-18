using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : EnemyController
{
    public float attackSpeed;
    private float distanceTravelled;
    private float distance;//distance to travel
    private Vector2 direction;

	new void Update () {
        base.Update();
        if (attacking && canMove)
        {
            myRigidbody.velocity = new Vector2(direction.x * attackSpeed, direction.y * attackSpeed);

            distanceTravelled += myRigidbody.velocity.magnitude * Time.deltaTime;
            if (distanceTravelled >= distance)
            {
                stopAttacking();
            }
            
        }
    }

    //slime will take the direction toward the player then charge in that direction for 2 seconds at high speed.
    //It moves in the same direction the whole time instead of actually chasing the player. It will stop at the 
    //point where the player was when the attack was initiated.
    public override void attack()
    {
        distanceTravelled = 0;
        distance = heading.magnitude;
        direction = heading / distance;
    }
}
