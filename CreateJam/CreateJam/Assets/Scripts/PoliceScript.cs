using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceScript : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public Transform Target;
    public float AggroRange;
    private float range;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
    }
}
