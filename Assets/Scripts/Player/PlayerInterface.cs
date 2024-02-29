

using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerInterface : MonoBehaviour
{

    public Camera mainCamera;
    public float interactionDistance = 2f;

    public GameObject interactionUI;
    public TextMeshProUGUI interationText;
    
    private Inventory inventory;

    private void Start()
    {
        gameObject.TryGetComponent<Inventory>(out inventory);   
    }

    private void Update()
    {
        InteractionRay();
    }
    public void InteractionRay()
    {
        Ray ray = mainCamera.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitObject = false;

        if(Physics.Raycast(ray, out hit, interactionDistance))
        {
            IPickable PickableItem = hit.collider.GetComponent<IPickable>();

            if(PickableItem != null ){
                hitObject = true;

                interationText.text = " Press E to Pick up " + PickableItem.GetItemName();

                if (Input.GetKeyDown(KeyCode.E))
                {
                   

                }

            }
        }

        interactionUI.SetActive(hitObject);
    }

}
