using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 speed = new Vector2(5f, 2f);

    public Vector2 targetPosition;

    public Vector2 relativePosition;
    private Vector2 movement;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) ;
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        relativePosition = new Vector2(
            targetPosition.x - gameObject.transform.position.x,
            targetPosition.y - gameObject.transform.position.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        if( speed.x * Time.deltaTime >=  Mathf.Abs(relativePosition.x)) {
            movement.x = relativePosition.x;   
        } else{
            movement.x = speed.x * Mathf.Sign(relativePosition.x);
        }
        if( speed.y * Time.deltaTime >=  Mathf.Abs(relativePosition.y) ) {
            movement.y = relativePosition.y;
        } else{
            movement.y = speed.y * Mathf.Sign(relativePosition.y);
        }
        GetComponent<Rigidbody2D>().velocity = movement;

    }
}
