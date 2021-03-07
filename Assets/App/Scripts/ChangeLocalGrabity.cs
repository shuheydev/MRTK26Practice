using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocalGrabity : MonoBehaviour
{
    [SerializeField]
    private Vector3 localGravity;
    private Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = this.GetComponent<Rigidbody>();
        rBody.useGravity = false;
    }

    private void FixedUpdate()
    {
        SetLocalGravity();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetLocalGravity()
    {
        rBody.AddForce(localGravity, ForceMode.Acceleration);
    }

    public void SetIsKinematics(bool isKinematics)
    {
        rBody.isKinematic = isKinematics;
    }
}
