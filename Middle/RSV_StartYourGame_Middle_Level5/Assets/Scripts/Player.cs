using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour {

    static private string attackTriggerName = "Attack";

    static private string axisHorizontal = "Horizontal";

    static private LayerMask mobMask {
        get {
            return LayerMask.GetMask("Mobs");
        }
    }

    static private LayerMask defaultMask {
        get {
            return LayerMask.GetMask("Default");
        }
    }

    static private float minActionCooldown = 1.2f;

    [SerializeField] private float actionCooldown = 1.2f;
    [SerializeField] private Transform aimTransform;

    private Collider2D selfCollider;
    private Transform selfTransform;
    private SpriteRenderer selfSpriteRenderer;
    private Animator selfAnimator;
    private float timeToAction = 0f;
    private List<Collider2D> groundColliders = new List<Collider2D>();

    private bool isTeleport = false;

    private void Awake() {
        selfAnimator = GetComponent<Animator>();
        selfCollider = GetComponent<Collider2D>();
        selfTransform = GetComponent<Transform>();
        selfSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    [Serializable] private class Staff {
        [SerializeField] private float physicalDamage = 200;
        [SerializeField] private float fireDamage = 715;
        private const float voidDamage = 0.015f;

        public void Use(IDamagable aim) {
            if (aim != null) {
                aim.ApplyDamage(physicalDamage, fireDamage, voidDamage);
            }
        }
    }

    [SerializeField] private Staff weapon;

    private bool isOnGround {
        get {
            return groundColliders.Count > 0;
        }
    }

    private void OnCollisionStay2D(Collision2D coll) {
        if (!groundColliders.Contains(coll.collider)) {
            foreach (var p in coll.contacts) {
                if (p.point.y < selfCollider.bounds.min.y) {
                    groundColliders.Add(coll.collider);
                    break;
                }
            }
                
        } 
    }

    void OnCollisionExit2D(Collision2D coll) {
        if (groundColliders.Contains(coll.collider)) {
            groundColliders.Remove(coll.collider);
        }
    }

    private void TryTeleport(Vector3 position)
    {
        if (isTeleport)
        {
            selfTransform.position = position;
            //Debug.Log(position);
        }
    }


    private void Attack() {
        selfAnimator.SetTrigger(attackTriggerName);
        weapon.Use(Physics2D.BoxCast(new Vector2(aimTransform.position.x, aimTransform.position.y), new Vector2(3, 2), 0, Vector3.zero, Mathf.Infinity, mobMask).collider?.gameObject?.GetComponent<IDamagable>());
        timeToAction = Mathf.Max(minActionCooldown, actionCooldown);
    }

    private void TurnRight() {
        selfSpriteRenderer.flipX = false;
    }

    private void TurnLeft() {
        selfSpriteRenderer.flipX = true;
    }

    private void Update()
    {
        if (timeToAction <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                RaycastHit2D[] raycasts = Physics2D.RaycastAll(ray, Vector2.zero);
                foreach (RaycastHit2D hit in raycasts)
                { // Если нажали на моба или пол
                    if (hit.transform.gameObject.layer == 6 || hit.transform.gameObject.layer == 7)
                    {
                        isTeleport = false;
                        Debug.Log("You can't teleport here");
                    }
                    // Если нажали на игрока - активируем телепорт
                    if (hit.transform.gameObject.layer == 8)
                    {
                        isTeleport = true;
                        Debug.Log("Teleport has been activated");
                    }
                    
                }
                // Поворачиваем игрока
                if (selfCollider.transform.position.x >= ray.x)
                {
                    TurnLeft();
                }
                if (selfCollider.transform.position.x < ray.x)
                {
                    TurnRight();
                }
                // Телепортируем
                TryTeleport(ray);
            }
        }
        timeToAction -= Time.deltaTime;
    }
}
