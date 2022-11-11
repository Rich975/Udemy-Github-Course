using System.Runtime.CompilerServices;
using UnityEngine;

public class LightBehaviour01 : MonoBehaviour
{
    [SerializeField] private Light light;
    public SphereCollider collider;

    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
        light = GetComponentInChildren<Light>();
        collider = GetComponentInChildren<SphereCollider>();

        float colliderRadius = collider.radius;

        Debug.Log(colliderRadius);

    }

    private void Update()
    {
        PlayerDistToLightCenter();
    }

    private void OnTriggerEnter(Collider other)
    {
 
    }

    public void PlayerDistToLightCenter()
    {
        Vector3 playerDistanceToCenter = player.transform.position - this.transform.position;
        //Debug.Log(playerDistanceToCenter);
        float zDist = Mathf.Abs(playerDistanceToCenter.z);

        if(zDist < 5)
        {
            light.intensity = (0.1f * 100 / zDist);

        }
        //light.intensity = Mathf.Clamp(light.intensity, 0, 3);




        // light intensity increases when player is nearing the lightsource
        // but intensity has to clamp between a minimun and maximum value


        //light.intensity = Mathf.Clamp(light.intensity, 0, 3);

    }



}