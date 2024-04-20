using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_Gold : BaseStatus
{
    public Status_Gold(float setValue) : base(setValue)
    {
    }

    protected override void PerformSetting(float amount)
    {
        amount = Mathf.Clamp(amount, 0f, 999999f);
        ValueChangedHandle(amount);
    }

    protected override void PerformAddition(float amount)
    {
        amount = Mathf.Clamp(amount, 0f, 999999f);
        ValueChangedHandle(amount);
    }

    protected override void PerformSubtraction(float amount)
    {
        amount = Mathf.Clamp(amount, 0f, 999999f);
        ValueChangedHandle(amount);
    }
}
