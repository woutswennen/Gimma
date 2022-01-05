using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] Player player;
    [SerializeField] UiController uiController;
    [SerializeField] float currentHealth;
    [SerializeField] float currentStamina;
    [SerializeField] float maxHealth;
    [SerializeField] float maxStamina;
    
    public bool paused;
    private Rigidbody2D rb;
    

    private void Start() {
        paused = false;
        rb = gameObject.GetComponent<Rigidbody2D>();
        uiController.SetMax(maxHealth, maxStamina);
    }

    public void TakeDamage(float damage){
        uiController.TakeDamageCamera();
        currentHealth = currentHealth - 10f;
        if(currentHealth <= 0){
            Dead();
        }
        else{
            uiController.SetHealth(currentHealth);
        }
    }
    public void LoseStamina(float amount){
        currentStamina = currentStamina - amount;
        uiController.SetStamina(currentStamina);
    }
    public void GainStamina(float amount){
        currentStamina = currentStamina + amount;
        if(currentStamina > maxStamina) currentStamina = maxStamina;
        uiController.SetStamina(currentStamina);
    }

    
    public void Dead(){
        resetPlayerPosition();
        stopPlayerMovement(1.5f);
        currentHealth = maxHealth;
        currentStamina = maxStamina;
        uiController.SetHealth(currentHealth);
        uiController.SetStamina(currentStamina);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Spikes"){
            TakeDamage(10);
        }
    }
    public void resetPlayerPosition(){
        transform.position = new Vector3(-2.8f, 1.82f, 0f);
    }

    public void stopPlayerMovement(float time){
        paused = true;
        Invoke("Unfreeze", time);
    }
    private void Unfreeze(){
        paused = false;
    }
    public bool isPaused(){
        return paused;
    }
}
