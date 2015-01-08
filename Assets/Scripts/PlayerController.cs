using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Vector3 move;
    private float moveSpeed = 10f;
    private Animator _anim;
    private Rigidbody2D _body;
    void Awake()
    {
        _anim = gameObject.GetComponent<Animator>();
        _body = gameObject.GetComponent<Rigidbody2D>();
        move = new Vector3(0, 0, 0);
    }

    // Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
        float horAxis = Input.GetAxis("Horizontal");
        float vertAxis = Input.GetAxis("Vertical");
        if (horAxis > 0)
        {
            move.x = moveSpeed;
            _anim.SetInteger("state", 1);
        }
        else if (horAxis < 0)
        {
            move.x = -moveSpeed;
            _anim.SetInteger("state", 3);
        }
        else if (horAxis == 0)
        {
            move.x = 0;
        }
        if (vertAxis > 0)
        {
            move.y = moveSpeed;
            _anim.SetInteger("state", 2);
        }
        else if (vertAxis < 0)
        {
            move.y = -moveSpeed;
            _anim.SetInteger("state", 0);
        }
        else if (vertAxis == 0)
        {
            move.y = 0;
        }
	}

    void FixedUpdate()
    {
        _body.velocity = move;
    }
}
