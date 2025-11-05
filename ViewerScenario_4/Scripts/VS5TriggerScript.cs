using UnityEngine;

public class VS5TriggerScript : MonoBehaviour
{


    private bool DoneOnce = false;

    [SerializeField] private GameObject Chair_GO;

    [SerializeField] private AudioSource JS_Source;

    [SerializeField] private SimpleCameraShake Shake_Script;

    private void OnTriggerEnter(Collider other)
    {

        // only do it once
        if (DoneOnce) return;
        DoneOnce = true;

        // active chair
        Chair_GO.SetActive(true);

        // active camera shake
        Shake_Script.Shake();

        // active jumpscare audio
        JS_Source.Play();




    }


}
