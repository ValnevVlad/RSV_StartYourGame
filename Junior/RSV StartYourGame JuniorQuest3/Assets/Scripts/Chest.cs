using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Chest : MonoBehaviour {

    [SerializeField] private Player player;
    [SerializeField] private KeyCode openKey = KeyCode.Space;
    [SerializeField] private Bonus healthBonus;
    [SerializeField] private Bonus manaBonus;
    [SerializeField] private Bonus coinBonus;

    [HideInInspector] public Bonus CurrentBonus;

    [SerializeField] public UnityEvent onOpen;

    private bool isLocked = false;

    private int i_max;
    private int i_min;
    private int i_average;

    private void Awake() {
        healthBonus.OnBonusViewDestroy.AddListener(Unlock);
        manaBonus.OnBonusViewDestroy.AddListener(Unlock);
        coinBonus.OnBonusViewDestroy.AddListener(Unlock);
    }

    private void Update() {
        if (!isLocked && Input.GetKeyDown(openKey)) {
            Open();
        }
    }

    private void Unlock() {
        isLocked = false;
    }

    private void Open() {
        isLocked = true;
        onOpen.Invoke();
    }

    private void OnOpenAnimationEnd() {
        // Алгоритм генерации лута пиши тут

        int[] player_charachteristics = { player.Characteristics.Health, player.Characteristics.Mana, player.Characteristics.Coin };
        Bonus[] player_bonuses = { healthBonus, manaBonus, coinBonus };

        // Определяем максимальное и минимальное значение характеристики персонажа
        int max_parametr = Mathf.Max(player_charachteristics);
        int min_parametr = Mathf.Min(player_charachteristics);
        //Debug.Log(max_parametr);

        // Определяем номер максимальных и минимальных значений
        for (int i = 0; i < player_charachteristics.Length; i++)
        {
            if (player_charachteristics[i] == max_parametr)
            {
                i_max = i;
            }
            else
            {
                if (player_charachteristics[i] == min_parametr)
                {
                    i_min = i;
                }
                else
                {
                    i_average = i;
                }
            }
            
        }

        //если максимальный параметр превышает средний более чем на 20 пунктов,
        //то бонус добавляется к среднему по величине параметру, иначе - к максимальному.
        if (player_charachteristics[i_max] - player_charachteristics[i_average] > 20)
        {
            player_bonuses[i_average].Apply(player);
        }
        else
        {
            player_bonuses[i_max].Apply(player);
        }

    }
}
