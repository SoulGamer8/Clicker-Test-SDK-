using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour
{
    [SerializeField] private ShopItemSO _shopItemSO;
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _textName;
    [SerializeField] private TMP_Text _textDescription;
    [SerializeField] private TMP_Text _textPrice;
    [SerializeField] private TMP_Text _textBonus;

    private void Start(){
        _image = _shopItemSO.Image;
        _textName.text = _shopItemSO.Name;
        _textDescription.text = _shopItemSO.Description;
        _textPrice.text = _shopItemSO.Price.ToString();
        _textBonus.text = _shopItemSO.Bonus.ToString();
    }
}