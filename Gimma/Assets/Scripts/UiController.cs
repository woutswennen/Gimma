using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{

    [SerializeField] HealthBar healthBar;
    [SerializeField] StaminaBar staminaBar;
    public Camera cam;

    private void Start() {
        
        cam.clearFlags = CameraClearFlags.SolidColor;
        
    }
    
    public void SetMax(float maxHealth, float maxStamina)
    {
        healthBar.SetMaxAmount(maxHealth);
        staminaBar.SetMaxAmount(maxStamina);
        //set current amount to max
        healthBar.SetAmount(maxHealth);
        staminaBar.SetAmount(maxStamina);
    }

    public void SetHealth(float health){
        healthBar.SetAmount(health);
    }

    public void SetStamina(float stamina){
        staminaBar.SetAmount(stamina);
    }

    public void TakeDamageCamera(){
        
        cam.backgroundColor = new Color(.71f, .10f, .10f, 0f);
        Invoke("BackgroundDefault", .2f);
    }
    public void BackgroundDefault(){
        cam.backgroundColor = new Color(.35f, .44f, .86f, 0f);
        
    }

}
