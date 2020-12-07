using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCollider : MonoBehaviour
{
    [SerializeField]
    private BatColliderFollower _batColliderFollowerPrefab;

    void Start()
    {
        spawnFollower();   
    }

    private void spawnFollower()
    {
        var follower = Instantiate(_batColliderFollowerPrefab);
        follower.transform.position = transform.localPosition;
        follower.setFollowTarget(gameObject);
    }
}
