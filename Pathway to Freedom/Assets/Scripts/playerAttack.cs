using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;

    private float timeToAttack = 0.5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 attackDir = mousePos - new Vector2(transform.position.x, transform.position.y);
            float angle = Mathf.Atan2(attackDir.y, attackDir.x) * Mathf.Rad2Deg;
            attackArea.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }

        if(attacking)
        {
            timer += Time.deltaTime;
            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }


}
