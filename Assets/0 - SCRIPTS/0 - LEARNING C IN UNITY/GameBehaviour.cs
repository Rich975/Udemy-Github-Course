using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public Button loseButton;
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
                UpdateScene("You've found all the items!");
                winButton.gameObject.SetActive(true);
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
            if (_playerHP <= 0)
            {
                UpdateScene("You want another life with that?");
                loseButton.gameObject.SetActive(true);
            }
            else
            {
                progressText.text = "Ouch...";
            }
        }
    }

    private void UpdateScene(string text)
    {
        progressText.text = text;
        Time.timeScale = 0; ;
    }

    public void RestartScene()
    {
        Utilities.RestartLevel(0);
    }
}