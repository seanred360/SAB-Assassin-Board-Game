using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssassinBoardGame;

public class PlayerDeath : MonoBehaviour
{
	// reference to AnimatorController
    public Animator playerAnimController;
    AudioManager m_audioManager;

    // string id for PlayerDeath trigger parameter
    public string playerDeathTrigger = "IsDead";

    private void Awake()
    {
        m_audioManager = Object.FindObjectOfType<AudioManager>().GetComponent<AudioManager>();
    }
    // play the death animation
    public void Die()
    {
        m_audioManager.PlaySFX(4);
        if (playerAnimController != null)
        {
            playerAnimController.SetTrigger(playerDeathTrigger);
        }
    }

}
