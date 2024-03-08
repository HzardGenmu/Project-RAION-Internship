using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{


    private Animator anim;
    private PlayerMovement playerMovement;

    [SerializeField] private float attackCD;
    private float cooldownTimer = Mathf.Infinity;
    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && cooldownTimer>attackCD && playerMovement.canAttack())
            Attack();
        

        cooldownTimer += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
        cooldownTimer = 0;
    }
}
