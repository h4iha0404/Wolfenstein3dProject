using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int enemyHP = 100;
    public int maxEnemyHP = 100;
    public GameObject projectile;
    public Transform projectilePoint;
    public bool isDied = false;
    public Image playerHPImage;

    public Animator animator;

    public void Start() {
        playerHPImage.gameObject.SetActive(true);
        playerHPImage.fillAmount = 1;
    }

    public void Shoot()
    {
        Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 30f, ForceMode.Impulse);
        rb.AddForce(transform.up * 10, ForceMode.Impulse);
    }

    public void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        playerHPImage.fillAmount = (float)enemyHP / (float)maxEnemyHP;
        if(enemyHP <= 0)
        {
            animator.SetTrigger("death");
            GetComponent<CapsuleCollider>().enabled = false;
            isDied = true;
            playerHPImage.gameObject.SetActive(false);
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
}
