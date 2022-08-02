using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntEvent : UnityEvent<int> { }

public class FloatEvent : UnityEvent<float> { }

public class GameEvents
{
    public static UnityEvent OnTestEvent = new UnityEvent();

    public static IntEvent OnPlayerHealth = new IntEvent();

    public static FloatEvent OnDamagePlayer = new FloatEvent();
}
