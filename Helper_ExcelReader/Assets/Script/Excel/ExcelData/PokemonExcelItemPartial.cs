using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PokemonExcelItem
{
    public override string ToString()
    {
        var str = $"id:{id} {name} " +
            $"attackTendency:{attackTendency} " +
            $"hp:{basicHp} " +
            $"attack:{basicAttack} " +
            $"defender:{basicDefender}";
        return str;
    }
}