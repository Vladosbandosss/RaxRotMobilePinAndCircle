using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAndSircleSpaner : MonoBehaviour
{
    [SerializeField] GameObject pinAndCirclePrafab;
    public static PinAndSircleSpaner instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   
    
    public void CreateNewPinAndCircle()
    {
        Instantiate(pinAndCirclePrafab, pinAndCirclePrafab.transform.position, pinAndCirclePrafab.transform.rotation);
    }

    public void Create()
    {
        Invoke(nameof(CreateNewPinAndCircle), 1f);
    }

   
}
