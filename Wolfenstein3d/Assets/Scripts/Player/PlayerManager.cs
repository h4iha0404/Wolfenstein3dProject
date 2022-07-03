using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP = 100;
    public TextMeshProUGUI playerHPvalue;
    public Image playerHPImage;
    public GameObject bloodOverlay;

    public static bool isGameOver;
    void Start()
    {
        isGameOver = false;
        playerHP = 100;
    }

    void Update()
    {
        playerHPImage.fillAmount = playerHP/100;
        playerHPvalue.text = playerHP.ToString() + " / 100";
        if (isGameOver)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public IEnumerator TakeDamage(int damageAmount)
    {
        bloodOverlay.SetActive(true);
        playerHP -= damageAmount;
        if (playerHP <= 0)
            isGameOver = true;

        yield return new WaitForSeconds(0.5f);
        bloodOverlay.SetActive(false);

    }
}
