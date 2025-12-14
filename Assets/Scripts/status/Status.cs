using UnityEngine;
using TMPro;

public class Status : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtHp;
    [SerializeField] private TextMeshProUGUI txtMp;
    [SerializeField] private TextMeshProUGUI txtMoney;

    public void UpdateStatus(int hp, int mp, int money)
    {
        txtHp.text = $"HP {hp}";
        txtMp.text = $"MP {mp}";
        txtMoney.text = $"$ {money}";
    }
}
