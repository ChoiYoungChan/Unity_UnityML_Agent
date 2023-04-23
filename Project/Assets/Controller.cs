using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class Controller : Agent
{
    private float speed = 10.0f;
    private new Rigidbody rigidbody;

    private new void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) rigidbody.AddForce(speed * Vector3.left);
        else if (Input.GetKey(KeyCode.D)) rigidbody.AddForce(speed * Vector3.right);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        int discrete = actions.DiscreteActions[0];
        //var continuous = Mathf.Clamp(actions.ContinuousActions[0], -1, 1.0f);

        Debug.Log("## " + discrete);
        //Debug.Log("## " + continuous);
    }
}
