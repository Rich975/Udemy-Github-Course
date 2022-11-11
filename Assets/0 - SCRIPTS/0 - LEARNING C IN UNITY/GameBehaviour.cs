using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public int maxItems = 4;

    public Text healthText;
    public Text itemText;
    public Text progressText;

    private void Start()
    {
        itemText.text += _itemsCollected;
        healthText.text += _playerHP;
    }

    public Button winButton;
    private int _itemsCollected = 0;

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            itemText.text = "Items Collected: " + Items;
            if (_itemsCollected >= maxItems)
            {
                progressText.text = "You've found all the items!";
                winButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                progressText.text = $"Item found, only {maxItems - _itemsCollected} more to go!";
            }
        }
    }

    private int _playerHP = 10;

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            healthText.text = "Player Health: " + HP;
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}