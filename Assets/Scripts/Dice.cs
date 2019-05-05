using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public Sprite[] diceSides;
    private Image m_rend;
    private bool coroutineAllowed = true;
    protected int m_randomDiceSide;
    public static int DiceNumberThrown;

    PlayerMover m_playerMover;
    PlayerInput m_playerInput;

    // Use this for initialization
    private void Start () {
        m_playerMover = FindObjectOfType<PlayerMover>();
        m_playerInput = FindObjectOfType<PlayerInput>();
        m_rend = GetComponent<Image>();
        m_rend.sprite = diceSides[1];
    }

    public void StartRoll()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        for (int i = 0; i <= 20; i++)
        {
            //this.gameObject.GetComponent<Button>().interactable = false;
            m_randomDiceSide = Random.Range(0, 2);
            m_rend.sprite = diceSides[m_randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        DiceNumberThrown = m_randomDiceSide + 1;
        m_playerInput.SetMaxKeystrokes(m_randomDiceSide +1);
    }
}
