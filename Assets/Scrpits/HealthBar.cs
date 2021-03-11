using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBarImage;
    public float currentHealth;
    private float maxHealth = 100f;
    PlayerMovement player;
    
    void Start()
    {
        healthBarImage = GetComponent<Image>();
        player = FindObjectOfType<PlayerMovement>();
    }
    
    void Update()
    {
        currentHealth = player.Health;
        healthBarImage.fillAmount = currentHealth / maxHealth;
    }
}
