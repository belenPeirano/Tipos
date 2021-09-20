using System;

public interface IElectric
{
    Boolean IsOn { get; }
    void TurnOn();
    void TurnOff();
}