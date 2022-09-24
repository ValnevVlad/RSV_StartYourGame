using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Goblin : MonoBehaviour, IDamagable {

    static private string hitTriggerName = "Hit";

    [SerializeField] private float hp = 0f;                   // здоровье моба
    [SerializeField] private float armor = 0f;                // броня моба
    [SerializeField] private float fireResistPercent = 0f;    // бонус к сопротивлению огненным предметам (в процентах)

    private Animator selfAnimator;

    private void Awake() {
        selfAnimator = GetComponent<Animator>();
    }

    public void ApplyDamage(float physicalDamage, float fireDamage, float voidDamage) {
        // в строке 20 напишите код с вычислениями урона по заданию весто присвоения значения 0f
        float damage = 200f + 0.015f * hp + 715f * fireResistPercent / 100f - armor;

        if (damage > 0) {
            hp -= damage;
        }
         selfAnimator.SetTrigger(hitTriggerName);
    }

    public void onHitAnimationEnd() {
        if (hp <= 0) {
            Kill();
        }
    }

    private void Kill() {
        Destroy(gameObject);
    }
}