using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PokemonExcelItem
{
    public override string ToString()
    {
        var str = $"id:{id} " +
            $"{name} " +
            $"attackTendency:{attackTendency} " +
            $"hp:{basicHp} " +
            $"atk:{basicAttack} " +
            $"def:{basicDefender} " +
            $"otherParam:[{string.Join(',', otherParam)}] " +
            $"strParam:[{string.Join(',', stringParam)}] ";
        return str;
    }
}
