using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform camTransform;
    public GameObject directionLight;
    public Transform lightTransform;

    // Start is called before the first frame update
    private void Start()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        //Character hero = new Character("Richie");
        //Debug.Log($"The hero's name is {hero.name} and he has {hero.exp} exp points");
        //hero.PrintStatsInfo(); //does same as above line but calls the method from Character class

        //Character heroine = new Character("Kuttel");
        //heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("HuntingBow", 4);

        //Weapon warBow = huntingBow;

        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats();

        //warBow.name = "War Bow";
        //warBow.damage = 69;

        //warBow.PrintWeaponStats();

        //Character hero2 = hero;
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();

        //hero2.name = "Sir knighty knight the nightryder";

        //Paladin knight = new Paladin("Ser Richturd", huntingBow);
        //knight.PrintStatsInfo();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void LoopThroughGameObject()
    {
    }
}