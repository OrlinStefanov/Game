using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Pick up")]
    public float range = 1f;
    public Camera cam;
    public TextMeshProUGUI textMeshPro;

    public RaycastHit hit;

    [Header("Box")]
    public Animator animator;

    [Header("player")]
    public Animator playerAnimator;

    [Header("Pistol")]
    public GameObject pistol_ground;
    public GameObject pistol;

	// Start is called before the first frame update
	void Start()
    {
        pistol_ground.SetActive(true);
        pistol.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Highlight"))
            {
                textMeshPro.text = "Press E to interact";
            }

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("whatisground"))
            {
                textMeshPro.text = "";
            }

            if (hit.transform.gameObject.name == "Box" && Input.GetKey(KeyCode.E))
            {
                animator.Play("open");

                playerAnimator.Play("Gathering");

                StartCoroutine(seconds());

				pistol.SetActive(true);
				pistol_ground.SetActive(false);
			}

		} else
        {
            textMeshPro.text = "";
        }

    }

    IEnumerator seconds()
    {
        yield return new WaitForSeconds(1);
	}
}
