using UnityEngine;
using UnityEngine.UI;

public class CountBar : MonoBehaviour
{
    public Slider countBar;
    public LootboxScript lootscript;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        lootscript = player.GetComponent<LootboxScript>();
    }

    void Update()
    {
        countBar.minValue = lootscript.meta / 2;
        countBar.maxValue = lootscript.meta;
        countBar.value = lootscript.count;
    }
}
