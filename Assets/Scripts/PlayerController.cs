using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    public TextMeshProUGUI score, over, id;
    private int goal = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        id.text = SystemInfo.deviceUniqueIdentifier;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0 , moveVertical);
        rb.AddForce(movement * speed);
        if(transform.position.y< 60){
            Destroy(gameObject);
            over.gameObject.SetActive(true);

        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Soccergoal"))
        {
            other.gameObject.SetActive(false);
            score.text = "SCORE: " + goal.ToString();
            goal++;
            if (goal == 230)
            {
                over.gameObject.SetActive(true);
            }
        }
        
    }
}
